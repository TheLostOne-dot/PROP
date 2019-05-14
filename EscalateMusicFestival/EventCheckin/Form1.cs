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
        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(Attached);
                myRFIDReader.Detach += new DetachEventHandler(Detached);
                myRFIDReader.Tag += new RFIDTagEventHandler(ReadTag);

                lbxNewidscan.Items.Add("Startup successfull");
            }
            catch (PhidgetException) { lbxNewidscan.Items.Add("Error at startup"); }
        }

        private void cbNoticket_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoticket.Checked == true)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
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

        public void ReadTag(object sender, RFIDTagEventArgs e)
        {
            lbxNewidscan.Items.Add("Checked In");
            lblCheckincheckout.Text = "ID: " + e.Tag + " checked in";
            

            if (lblCheckincheckout.Text != "")
            {
                
                int nrAdded = dh.AddNewVisitorID(tbID.Text,e.Tag);
                if (nrAdded > 0)
                {
                    lblCheckincheckout.Text = "Checked in Visitor: " + e.Tag;
                }
                else
                {
                    lblCheckincheckout.Text = "Checked out Visitor: " + e.Tag;
                } 
            } 
        }

    }
}
