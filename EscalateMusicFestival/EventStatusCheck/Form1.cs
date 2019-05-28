using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventStatusCheck
{

    public partial class Form1 : Form
    {
        private DataHelper dh;
        private double totalspent = 0;
        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
            List<string> shops;
            shops = dh.StandsSelect();

            lbxShops.Items.Clear();
            foreach (string s in shops)
            {

                lbxShops.Items.Add(s);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMoneymade_Click(object sender, EventArgs e)
        {
            lblMoneymade.Text = "Amount Made: "+ dh.ShopMoneyMadeSelect(lbxShops.SelectedItem.ToString()) + " euros";
            if (dh.ShopMoneyMadeSelect(lbxShops.SelectedItem.ToString()) == -1)
            {
            lblMoneymade.Text = "Amount Made: " + dh.LoanStandMoneyMadeSelect(lbxShops.SelectedItem.ToString()) + " euros";
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalamountvisitors_Click(object sender, EventArgs e)
        {

        }

        private void btnShowvisitors_Click(object sender, EventArgs e)
        {
            List<string> visitors;
            visitors = dh.PresentVisitorsSelect();

            lbxVisitorspresent.Items.Clear();
            foreach (string v in visitors)
            {

                lbxVisitorspresent.Items.Add(v);

            }
        }

        private void btnVisitorsinfo_Click(object sender, EventArgs e)
        {
            this.totalspent = dh.TotalSpentLoanedSum() + dh.TotalSpentPurchasedSum() + dh.TotalSpentReserved();

            lbxVisitorspresent.Items.Clear();
            lbxVisitorspresent.Items.Add("Total Amount of Visitors: " + dh.TotalVisitorsCount());
            lbxVisitorspresent.Items.Add("Total Balance of all Visitors: " + dh.TotalBalanceSum() + " euros");
            lbxVisitorspresent.Items.Add("Total Amount Spent by Visitors: " + this.totalspent + " euros");

        }

        private void btnCampstats_Click(object sender, EventArgs e)
        {
            lbxCampingstats.Items.Clear();
            lbxCampingstats.Items.Add("Total Amount of Reserved Spots: " + dh.TotalReservedCount());
            lbxCampingstats.Items.Add("Total Amount Made for Camping: " + dh.TotalMoneyMadeReserved()+" euros");
            lbxCampingstats.Items.Add("Total Amount of Visitors at CampingSpots: " + dh.TotalVisitorsSpots());
            lbxCampingstats.Items.Add("Average Amount of Visitors per CampingSpot: " + dh.AvgVisitorsSpots());
            lbxCampingstats.Items.Add("Average Amount Made per CampingSpot: " + dh.AvgMadeSpots() + " euros");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAmountsold_Click(object sender, EventArgs e)
        {
            lblAmountsold.Text = "A Total Amount of: " + dh.AmountSoldSelect(tbItem.Text)+ " was sold";
        }

        private void btnShowVisitorInfo_Click(object sender, EventArgs e)
        {
            List<string> history;
            history = dh.HistoryOrder(tbVisitorID.Text);

            lbxVisitorHistory.Items.Clear();
            foreach (string h in history)
            {
                lbxVisitorHistory.Items.Add(h);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
