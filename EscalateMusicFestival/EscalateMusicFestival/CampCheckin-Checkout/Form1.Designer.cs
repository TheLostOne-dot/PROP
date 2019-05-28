namespace CampCheckin_Checkout
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManual = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxIDscan = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnShowtotalprice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAvailablecampingspots = new System.Windows.Forms.ListBox();
            this.tbAmountofPersons = new System.Windows.Forms.TextBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(677, 402);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(111, 36);
            this.btnManual.TabIndex = 15;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(74, 94);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 44);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(74, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 47);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open Connection";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxIDscan);
            this.groupBox1.Location = new System.Drawing.Point(327, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 116);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // lbxIDscan
            // 
            this.lbxIDscan.FormattingEnabled = true;
            this.lbxIDscan.ItemHeight = 16;
            this.lbxIDscan.Location = new System.Drawing.Point(19, 39);
            this.lbxIDscan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxIDscan.Name = "lbxIDscan";
            this.lbxIDscan.Size = new System.Drawing.Size(407, 52);
            this.lbxIDscan.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.btnShowInfo);
            this.groupBox2.Controls.Add(this.tbAmountofPersons);
            this.groupBox2.Controls.Add(this.btnMakePayment);
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.btnShowtotalprice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbxAvailablecampingspots);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 252);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(416, 194);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(305, 41);
            this.btnMakePayment.TabIndex = 22;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(538, 157);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(80, 17);
            this.lblTotalPrice.TabIndex = 21;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // btnShowtotalprice
            // 
            this.btnShowtotalprice.Location = new System.Drawing.Point(515, 111);
            this.btnShowtotalprice.Name = "btnShowtotalprice";
            this.btnShowtotalprice.Size = new System.Drawing.Size(129, 34);
            this.btnShowtotalprice.TabIndex = 20;
            this.btnShowtotalprice.Text = "Show Price";
            this.btnShowtotalprice.UseVisualStyleBackColor = true;
            this.btnShowtotalprice.Click += new System.EventHandler(this.btnShowtotalprice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Amount of persons:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Camping Spots:";
            // 
            // lbxAvailablecampingspots
            // 
            this.lbxAvailablecampingspots.FormattingEnabled = true;
            this.lbxAvailablecampingspots.ItemHeight = 16;
            this.lbxAvailablecampingspots.Location = new System.Drawing.Point(9, 39);
            this.lbxAvailablecampingspots.Name = "lbxAvailablecampingspots";
            this.lbxAvailablecampingspots.Size = new System.Drawing.Size(104, 196);
            this.lbxAvailablecampingspots.TabIndex = 0;
            this.lbxAvailablecampingspots.SelectedIndexChanged += new System.EventHandler(this.lbxAvailablecampingspots_SelectedIndexChanged);
            // 
            // tbAmountofPersons
            // 
            this.tbAmountofPersons.Location = new System.Drawing.Point(581, 70);
            this.tbAmountofPersons.Name = "tbAmountofPersons";
            this.tbAmountofPersons.Size = new System.Drawing.Size(100, 22);
            this.tbAmountofPersons.TabIndex = 23;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(190, 103);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(130, 42);
            this.btnShowInfo.TabIndex = 17;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(119, 157);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 17);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Camp Checkin/Checkout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxIDscan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnShowtotalprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAvailablecampingspots;
        private System.Windows.Forms.TextBox tbAmountofPersons;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lblInfo;
    }
}

