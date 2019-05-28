using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalateMusicFestival
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(49) + @"\End-of-Event\bin\Debug\End-of-Event.exe");
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(49) + @"\CampCheckin-Checkout\bin\Debug\CampCheckin-Checkout.exe");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(49) + @"\EventCheckin\bin\Debug\EventCheckin.exe");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(49) + @"\EventStatusCheck\bin\Debug\EventStatusCheck.exe");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(49) + @"\LoanStands\bin\Debug\LoanStands.exe");
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(49) + @"\Shops\bin\Debug\Shops.exe");
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString().Remove(49) + @"\TransactionLogFileConversion\bin\Debug\TransactionLogFileConversion.exe");
            this.Close();
        }
    }
}
