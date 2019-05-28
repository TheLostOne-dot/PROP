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

        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
           

        }

        private void btnStartLog_Click(object sender, EventArgs e)
        {
            lbxLogs.DataSource = dh.ReturnTransactionlog();
            dh.Transaction("transaction.txt");
        }
    }
}
