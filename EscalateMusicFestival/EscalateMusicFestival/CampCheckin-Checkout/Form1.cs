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

namespace CampCheckin_Checkout
{
    public partial class Form1 : Form
    {
        private RFID myRFIDReader;
        private DataHelper dh;
        private string tag = "";
        private double total = 0;
        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(Attached);
                myRFIDReader.Detach += new DetachEventHandler(Detached);
                myRFIDReader.Tag += new RFIDTagEventHandler(ReadTagID);

                lbxIDscan.Items.Add("Startup successfull");

            }
            catch (PhidgetException) { lbxIDscan.Items.Add("Error at startup"); }
            tbAmountofPersons.Text = Convert.ToString(0);
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Open();
                lbxIDscan.Items.Add("Connection opened");

            }
            catch (PhidgetException)
            {
                lbxIDscan.Items.Clear();
                lbxIDscan.Items.Add("Connection failed:Please try again");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            myRFIDReader.Close();
            lbxIDscan.Items.Add("Connection closed");
        }

        public void Attached(object sender, AttachEventArgs e) //for when RFID is plugged in
        {
            lbxIDscan.Items.Add("RFID Reader attached");
        }

        public void Detached(object sender, DetachEventArgs e) //for when RFID is unplugged
        {
            lbxIDscan.Items.Add("RFID Reader detached");
        }

        public void ReadTagID(object sender, RFIDTagEventArgs e)
        {
            this.tag = e.Tag;
            if(dh.CheckReservationSelect(e.Tag) == true)
            {
                lbxIDscan.Items.Clear();
                lbxIDscan.Items.Add("Checked in Visitor: " + e.Tag);
                if (dh.CheckedinCheckoutSelect(e.Tag) == "No")
                {
                    int catchnr2 = dh.Checkin(e.Tag);
                    if (catchnr2 > 0)
                    {

                        lbxIDscan.Items.Clear();
                        lbxIDscan.Items.Add("Checked In Visitor: " + e.Tag);
                        // lblCheckincheckout.Text = "Checked in Visitor: " + e.Tag;


                    }
                    else
                    {
                        // lblCheckincheckout.Text = "Check in failed";
                        lbxIDscan.Items.Add("Checked In Failed" /*+ e.Tag*/);

                    }

                }
                else if (dh.CheckedinCheckoutSelect(e.Tag) == "Yes")
                {
                    int catchnr2 = dh.Checkout(e.Tag);
                    if (catchnr2 > 0)
                    {

                        lbxIDscan.Items.Clear();
                        lbxIDscan.Items.Add("Checked Out Visitor: " + e.Tag);
                        // lblCheckincheckout.Text = "Checked out Visitor: " + e.Tag;


                    }
                    else
                    {
                        // lblCheckincheckout.Text = "Checkout failed";
                        lbxIDscan.Items.Add("Checked Out Failed" /*+ e.Tag*/);
                    }

                }

            }
            else
            {

                lbxIDscan.Items.Clear();
                lbxIDscan.Items.Add("Visitor: "+ e.Tag + " has no reservation, please make one");
                groupBox2.Visible = true;
                List<string> spots;
                spots = dh.NonReservedSelect();
               
                lbxAvailablecampingspots.Items.Clear();
                foreach (string s in spots)
                {

                    lbxAvailablecampingspots.Items.Add(s);
                    
                }
                lbxAvailablecampingspots.SelectedIndex = 0;


            }


        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if(dh.BalanceSelect(this.tag) > this.total)
            {
                double change = dh.BalanceSelect(this.tag) - this.total;
                int catchnr = dh.AddReservation(dh.CampingIDSelect(lbxAvailablecampingspots.SelectedItem.ToString()),this.tag,Convert.ToInt32(tbAmountofPersons.Text),this.total);
                int catchnr2 = dh.AddNewBalance(this.tag, change);
                if (catchnr > 0 && catchnr2 > 0)
                { 
                    MessageBox.Show("Camping Spot Reserved, please Check in Visitor");
                    groupBox2.Visible = false;

                }
                else
                {
                    MessageBox.Show("Payment Failed");
                }
            }
            else if (dh.BalanceSelect(this.tag) < this.total)
            {
                MessageBox.Show("Not Enough Funds");
            }


        }

        private void btnShowtotalprice_Click(object sender, EventArgs e)
        {
            this.total = (Convert.ToInt32(tbAmountofPersons.Text) * dh.PricePerPersonSelect(lbxAvailablecampingspots.SelectedItem.ToString())) + 10;
            lblTotalPrice.Text = Convert.ToString(this.total);       // Convert.ToString(this.total);
        }

        private void lbxAvailablecampingspots_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            
            lblInfo.Text = "Capacity of " + dh.CampingCapacitySelect(lbxAvailablecampingspots.SelectedItem.ToString()) + " persons at " + dh.PricePerPersonSelect(lbxAvailablecampingspots.SelectedItem.ToString()) + " euros per person";
        }
    }
}
