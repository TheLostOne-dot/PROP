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

namespace End_of_Event
{
    public partial class Form1 : Form
    {
        private string tag;
        private RFID myRFIDReader;
        private DataHelper dh;
        
        public Form1()
        {
            InitializeComponent();
            tag = "";
            myRFIDReader = new RFID();
            dh = new DataHelper();
            myRFIDReader.Attach += MyRFID_Attached;
            myRFIDReader.Detach += MyRFID_Detached;
            myRFIDReader.Tag += MyRFID_Taged;
        }
        public void MyRFID_Attached(object sender, AttachEventArgs args)
        {
            lbxIDscan.Items.Add("RFID Reader attached");
        }
        public void MyRFID_Detached(object sender, DetachEventArgs args)
        {
            lbxIDscan.Items.Add("RFID Reader detached");
        }
        public void MyRFID_Taged(object sender, RFIDTagEventArgs args)
        {
            lbxIDscan.Items.Add($"RFID Taged! ID: {args.Tag}");
            tag = args.Tag.ToString();
            double balance = dh.GetBalance(args.Tag);
            if (balance > -1)
            {
                lbBalance.Text = balance.ToString() + "€";
            }
            else
            {
                lbBalance.Text = "0€";
            }
            List<List<string>> inf = dh.Items(args.Tag);
            int i = 0;
            if (!inf.Any())
            {
                
                button1.Enabled = true;
                
            }
            else
            {
                
                button1.Enabled = false;
                foreach (var g in inf)
                {
                    lbxLoaneditems.Items.Add($"Item: {g[0]} with Price of {g[1]}€ from Stand: {g[2]} is STILL LOANED");
                    i++;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnShowloaneditems_Click(object sender, EventArgs e)
        {
            //if (lbxLoaneditems == null)
            //{
            //    MessageBox.Show("No Loaned Items");
            //}
            //else
            //{
            //    lbxLoaneditems.Visible = true;
            //}
            
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            myRFIDReader.Close();
            lbxIDscan.Items.Add("Connection closed");
        }

        private void btnMakeInvalid_Click(object sender, EventArgs e)
        {
            if (tag != "")
            {
                int valid = dh.Invalid(tag);
                if (valid > -1)
                {
                    lbxIDscan.Items.Add($"{tag} Marked as Invalid");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void labelBalance_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int l = Application.StartupPath.ToString().Length;
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(l - 22) + @"\EscalateMusicFestival\bin\Debug\EscalateMusicFestival.exe");
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
