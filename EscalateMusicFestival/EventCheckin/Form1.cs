using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace EventCheckin
{
    public partial class Form1 : Form
    {
        private RFID myRFIDReader;
        private DataHelper dh;
        private Looper l;
        public Form1()
        {
            InitializeComponent();
            l = new Looper();
            dh = new DataHelper();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(Attached);
                myRFIDReader.Detach += new DetachEventHandler(Detached);
                myRFIDReader.Tag += new RFIDTagEventHandler(ReadTagNewID);

                lbxNewidscan.Items.Add("Startup successfull");
               
            }
            catch (PhidgetException) { lbxNewidscan.Items.Add("Error at startup"); }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e) //opens connection to RFID
        {
            try
            {
                myRFIDReader.Open();
                lbxNewidscan.Items.Add("Connection opened");

            }
            catch (PhidgetException)
            {
                lbxNewidscan.Items.Clear();
                lbxNewidscan.Items.Add("Connection failed:Please try again");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) //closes connection to RFID
        {
            myRFIDReader.Close();
            lbxNewidscan.Items.Add("Connection closed");
        }

        public void Attached(object sender, AttachEventArgs e) //for when RFID is plugged in
        {
            lbxNewidscan.Items.Add("RFID Reader attached");
        }

        public void Detached(object sender, DetachEventArgs e) //for when RFID is unplugged
        {
            lbxNewidscan.Items.Add("RFID Reader detached");
        }

        public void ReadTagNewID(object sender, RFIDTagEventArgs e)
        {


            int catchnr = dh.AddNewVisitorID(tbID.Text, e.Tag);
            if (catchnr > 0)
            {

                lbxNewidscan.Items.Clear();
                lbxNewidscan.Items.Add("Checked In with bracelet: " + e.Tag);
                dh.AddLogCheckedIn(e.Tag); 
            } 
            else
            {   
                if (dh.CheckedinCheckoutSelect(e.Tag) == "No")
                {
                    int catchnr2 = dh.Checkin(e.Tag);
                   
                    if (catchnr2 > 0)
                    {
                        lbxNewidscan.Items.Clear();
                        lbxNewidscan.Items.Add("Checked In Visitor: " + e.Tag);
                        dh.AddLogCheckedIn(e.Tag);
                    }
                    else
                    {
                        lbxNewidscan.Items.Add("Checked In Failed" /*+ e.Tag*/);
                    }
                    
                }
                else if (dh.CheckedinCheckoutSelect(e.Tag) == "Yes")
                {
                    int catchnr2 = dh.Checkout(e.Tag);
                   
                    if (catchnr2 > 0)
                    {

                        lbxNewidscan.Items.Clear();
                        lbxNewidscan.Items.Add("Checked Out Visitor: " + e.Tag);
                        dh.AddLogCheckedOut(e.Tag);
                    }
                    else
                    {
                        lbxNewidscan.Items.Add("Checked Out Failed" /*+ e.Tag*/);
                    }
                    
                }

            }
        }

            private void lbxNewidscan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
           lblGeneratedIDnr.Text = l.LoopID();
             
        }

        private void btnStoreid_Click(object sender, EventArgs e)
        {
            int catchnr = dh.AddVisitor(lblGeneratedIDnr.Text);

            if (catchnr > 0)
            {

                lblStored.Text = "Stored Visitor: " + lblGeneratedIDnr.Text;


            }
            else
            {
                lblStored.Text = "Failed to store Visitor";
            }


            }
    }
}
