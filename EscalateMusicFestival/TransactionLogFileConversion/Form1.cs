using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace TransactionLogFileConversion
{
    public partial class Form1 : Form
    {
        private DataHelper dh;
        public MySqlConnection connection;
        Timer timer = new Timer();


        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
           

        }
        void timer_Tick(object sender, EventArgs e)
        {
            lbxLogs.Items.Clear();

            MessageBox.Show("Database updated");
            dh.Transaction("transaction.txt");
            
            //lbxLogs.DataSource = dh.ReturnTransactionlog();
            for (int i = 0; i < dh.ReturnTransactionlog().Count; i++)
            {
                
                lbxLogs.Items.Add(dh.ReturnTransactionlog().ElementAt(i));
            }
        }
        private void btnStartLog_Click(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (5);             // Timer will tick evert 10 seconds
            timer.Enabled = true;           // Enable the timer
            timer.Start();                              // Start the timer
            
            

            
        }
    }
}
