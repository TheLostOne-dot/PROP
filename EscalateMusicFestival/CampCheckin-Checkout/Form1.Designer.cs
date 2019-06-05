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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.tbAmountofPersons = new System.Windows.Forms.TextBox();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnShowtotalprice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAvailablecampingspots = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Black;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManual.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManual.Location = new System.Drawing.Point(11, 350);
            this.btnManual.Margin = new System.Windows.Forms.Padding(2);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(179, 29);
            this.btnManual.TabIndex = 15;
            this.btnManual.Text = "MANUAL";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(12, 199);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 38);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "CLOSE CONNECTION";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Black;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpen.Location = new System.Drawing.Point(12, 157);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(179, 38);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "OPEN CONNECTION";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxIDscan);
            this.groupBox1.Location = new System.Drawing.Point(220, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(459, 94);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lbxIDscan
            // 
            this.lbxIDscan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxIDscan.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxIDscan.FormattingEnabled = true;
            this.lbxIDscan.ItemHeight = 18;
            this.lbxIDscan.Location = new System.Drawing.Point(7, 19);
            this.lbxIDscan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxIDscan.Name = "lbxIDscan";
            this.lbxIDscan.Size = new System.Drawing.Size(427, 54);
            this.lbxIDscan.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.btnShowInfo);
            this.groupBox2.Controls.Add(this.tbAmountofPersons);
            this.groupBox2.Controls.Add(this.btnMakePayment);
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.btnShowtotalprice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbxAvailablecampingspots);
            this.groupBox2.Location = new System.Drawing.Point(215, 157);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(464, 298);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(9, 248);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(36, 18);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Info";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.Color.Black;
            this.btnShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowInfo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowInfo.Location = new System.Drawing.Point(4, 205);
            this.btnShowInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(103, 34);
            this.btnShowInfo.TabIndex = 17;
            this.btnShowInfo.Text = "SHOW INFO";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // tbAmountofPersons
            // 
            this.tbAmountofPersons.Location = new System.Drawing.Point(363, 20);
            this.tbAmountofPersons.Margin = new System.Windows.Forms.Padding(2);
            this.tbAmountofPersons.Name = "tbAmountofPersons";
            this.tbAmountofPersons.Size = new System.Drawing.Size(76, 20);
            this.tbAmountofPersons.TabIndex = 23;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.Black;
            this.btnMakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakePayment.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakePayment.Location = new System.Drawing.Point(217, 205);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(222, 34);
            this.btnMakePayment.TabIndex = 22;
            this.btnMakePayment.Text = "MAKE PAYMENT";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(214, 83);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(85, 18);
            this.lblTotalPrice.TabIndex = 21;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // btnShowtotalprice
            // 
            this.btnShowtotalprice.BackColor = System.Drawing.Color.Black;
            this.btnShowtotalprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowtotalprice.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowtotalprice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowtotalprice.Location = new System.Drawing.Point(217, 44);
            this.btnShowtotalprice.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowtotalprice.Name = "btnShowtotalprice";
            this.btnShowtotalprice.Size = new System.Drawing.Size(222, 28);
            this.btnShowtotalprice.TabIndex = 20;
            this.btnShowtotalprice.Text = "SHOW PRICE";
            this.btnShowtotalprice.UseVisualStyleBackColor = false;
            this.btnShowtotalprice.Click += new System.EventHandler(this.btnShowtotalprice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Amount of persons:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Camping Spots:";
            // 
            // lbxAvailablecampingspots
            // 
            this.lbxAvailablecampingspots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxAvailablecampingspots.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailablecampingspots.FormattingEnabled = true;
            this.lbxAvailablecampingspots.ItemHeight = 18;
            this.lbxAvailablecampingspots.Location = new System.Drawing.Point(7, 41);
            this.lbxAvailablecampingspots.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAvailablecampingspots.Name = "lbxAvailablecampingspots";
            this.lbxAvailablecampingspots.Size = new System.Drawing.Size(100, 144);
            this.lbxAvailablecampingspots.TabIndex = 0;
            this.lbxAvailablecampingspots.SelectedIndexChanged += new System.EventHandler(this.lbxAvailablecampingspots_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampCheckin_Checkout.Properties.Resources.Resized;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 140);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(205, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 465);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 54);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "⮘  BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(13, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 5);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(208, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 5);
            this.panel3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(191, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 250);
            this.panel4.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Camp Checkin/Checkout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}

