namespace EventStatusCheck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxVisitorHistory = new System.Windows.Forms.ListBox();
            this.lblVisitorStatus = new System.Windows.Forms.Label();
            this.btnShowVisitorInfo = new System.Windows.Forms.Button();
            this.tbVisitorID = new System.Windows.Forms.TextBox();
            this.lblVisitorID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowvisitors = new System.Windows.Forms.Button();
            this.lbxVisitorspresent = new System.Windows.Forms.ListBox();
            this.btnTotalvisitors = new System.Windows.Forms.Button();
            this.lblTotalvisitors = new System.Windows.Forms.Label();
            this.btnTotalbalance = new System.Windows.Forms.Button();
            this.lblTotalbalance = new System.Windows.Forms.Label();
            this.btnTotalspent = new System.Windows.Forms.Button();
            this.lblTotalspent = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbxShops = new System.Windows.Forms.ListBox();
            this.btnMoneymade = new System.Windows.Forms.Button();
            this.lblMoneymade = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAmountsold = new System.Windows.Forms.Button();
            this.lblAmountsold = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.btnTotalreserved = new System.Windows.Forms.Button();
            this.btnTotalmoneymade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalreservedspots = new System.Windows.Forms.Label();
            this.lblTotalmoneymade = new System.Windows.Forms.Label();
            this.lblTotalamountvisitors = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxVisitorHistory);
            this.groupBox1.Controls.Add(this.lblVisitorStatus);
            this.groupBox1.Controls.Add(this.btnShowVisitorInfo);
            this.groupBox1.Controls.Add(this.tbVisitorID);
            this.groupBox1.Controls.Add(this.lblVisitorID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor";
            // 
            // lbxVisitorHistory
            // 
            this.lbxVisitorHistory.FormattingEnabled = true;
            this.lbxVisitorHistory.ItemHeight = 16;
            this.lbxVisitorHistory.Location = new System.Drawing.Point(121, 129);
            this.lbxVisitorHistory.Name = "lbxVisitorHistory";
            this.lbxVisitorHistory.Size = new System.Drawing.Size(231, 84);
            this.lbxVisitorHistory.TabIndex = 5;
            // 
            // lblVisitorStatus
            // 
            this.lblVisitorStatus.AutoSize = true;
            this.lblVisitorStatus.Location = new System.Drawing.Point(33, 158);
            this.lblVisitorStatus.Name = "lblVisitorStatus";
            this.lblVisitorStatus.Size = new System.Drawing.Size(48, 17);
            this.lblVisitorStatus.TabIndex = 4;
            this.lblVisitorStatus.Text = "Status";
            // 
            // btnShowVisitorInfo
            // 
            this.btnShowVisitorInfo.Location = new System.Drawing.Point(76, 80);
            this.btnShowVisitorInfo.Name = "btnShowVisitorInfo";
            this.btnShowVisitorInfo.Size = new System.Drawing.Size(100, 28);
            this.btnShowVisitorInfo.TabIndex = 3;
            this.btnShowVisitorInfo.Text = "Show Info";
            this.btnShowVisitorInfo.UseVisualStyleBackColor = true;
            // 
            // tbVisitorID
            // 
            this.tbVisitorID.Location = new System.Drawing.Point(76, 35);
            this.tbVisitorID.Name = "tbVisitorID";
            this.tbVisitorID.Size = new System.Drawing.Size(100, 22);
            this.tbVisitorID.TabIndex = 2;
            // 
            // lblVisitorID
            // 
            this.lblVisitorID.AutoSize = true;
            this.lblVisitorID.Location = new System.Drawing.Point(6, 35);
            this.lblVisitorID.Name = "lblVisitorID";
            this.lblVisitorID.Size = new System.Drawing.Size(64, 17);
            this.lblVisitorID.TabIndex = 1;
            this.lblVisitorID.Text = "VisitorID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalspent);
            this.groupBox2.Controls.Add(this.btnTotalspent);
            this.groupBox2.Controls.Add(this.lblTotalbalance);
            this.groupBox2.Controls.Add(this.btnTotalbalance);
            this.groupBox2.Controls.Add(this.lblTotalvisitors);
            this.groupBox2.Controls.Add(this.btnTotalvisitors);
            this.groupBox2.Controls.Add(this.lbxVisitorspresent);
            this.groupBox2.Controls.Add(this.btnShowvisitors);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitors";
            // 
            // btnShowvisitors
            // 
            this.btnShowvisitors.Location = new System.Drawing.Point(6, 52);
            this.btnShowvisitors.Name = "btnShowvisitors";
            this.btnShowvisitors.Size = new System.Drawing.Size(110, 48);
            this.btnShowvisitors.TabIndex = 0;
            this.btnShowvisitors.Text = "Show Visitors Present";
            this.btnShowvisitors.UseVisualStyleBackColor = true;
            // 
            // lbxVisitorspresent
            // 
            this.lbxVisitorspresent.FormattingEnabled = true;
            this.lbxVisitorspresent.ItemHeight = 16;
            this.lbxVisitorspresent.Location = new System.Drawing.Point(122, 21);
            this.lbxVisitorspresent.Name = "lbxVisitorspresent";
            this.lbxVisitorspresent.Size = new System.Drawing.Size(230, 100);
            this.lbxVisitorspresent.TabIndex = 2;
            // 
            // btnTotalvisitors
            // 
            this.btnTotalvisitors.Location = new System.Drawing.Point(9, 161);
            this.btnTotalvisitors.Name = "btnTotalvisitors";
            this.btnTotalvisitors.Size = new System.Drawing.Size(107, 63);
            this.btnTotalvisitors.TabIndex = 2;
            this.btnTotalvisitors.Text = "View Total Amount of Visitors";
            this.btnTotalvisitors.UseVisualStyleBackColor = true;
            // 
            // lblTotalvisitors
            // 
            this.lblTotalvisitors.AutoSize = true;
            this.lblTotalvisitors.Location = new System.Drawing.Point(16, 243);
            this.lblTotalvisitors.Name = "lblTotalvisitors";
            this.lblTotalvisitors.Size = new System.Drawing.Size(90, 17);
            this.lblTotalvisitors.TabIndex = 3;
            this.lblTotalvisitors.Text = "Total Visitors";
            // 
            // btnTotalbalance
            // 
            this.btnTotalbalance.Location = new System.Drawing.Point(132, 161);
            this.btnTotalbalance.Name = "btnTotalbalance";
            this.btnTotalbalance.Size = new System.Drawing.Size(104, 63);
            this.btnTotalbalance.TabIndex = 2;
            this.btnTotalbalance.Text = "View Total Balance of Visitors";
            this.btnTotalbalance.UseVisualStyleBackColor = true;
            // 
            // lblTotalbalance
            // 
            this.lblTotalbalance.AutoSize = true;
            this.lblTotalbalance.Location = new System.Drawing.Point(141, 243);
            this.lblTotalbalance.Name = "lblTotalbalance";
            this.lblTotalbalance.Size = new System.Drawing.Size(95, 17);
            this.lblTotalbalance.TabIndex = 4;
            this.lblTotalbalance.Text = "Total Balance";
            // 
            // btnTotalspent
            // 
            this.btnTotalspent.Location = new System.Drawing.Point(251, 161);
            this.btnTotalspent.Name = "btnTotalspent";
            this.btnTotalspent.Size = new System.Drawing.Size(101, 63);
            this.btnTotalspent.TabIndex = 2;
            this.btnTotalspent.Text = "View Total Money Spent by Visitors";
            this.btnTotalspent.UseVisualStyleBackColor = true;
            // 
            // lblTotalspent
            // 
            this.lblTotalspent.AutoSize = true;
            this.lblTotalspent.Location = new System.Drawing.Point(260, 243);
            this.lblTotalspent.Name = "lblTotalspent";
            this.lblTotalspent.Size = new System.Drawing.Size(81, 17);
            this.lblTotalspent.TabIndex = 5;
            this.lblTotalspent.Text = "Total Spent";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalamountvisitors);
            this.groupBox3.Controls.Add(this.lblTotalmoneymade);
            this.groupBox3.Controls.Add(this.lblTotalreservedspots);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnTotalmoneymade);
            this.groupBox3.Controls.Add(this.btnTotalreserved);
            this.groupBox3.Location = new System.Drawing.Point(376, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camping Spots";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.lblMoneymade);
            this.groupBox4.Controls.Add(this.btnMoneymade);
            this.groupBox4.Controls.Add(this.lbxShops);
            this.groupBox4.Location = new System.Drawing.Point(376, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 281);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shops";
            // 
            // lbxShops
            // 
            this.lbxShops.FormattingEnabled = true;
            this.lbxShops.ItemHeight = 16;
            this.lbxShops.Location = new System.Drawing.Point(6, 21);
            this.lbxShops.Name = "lbxShops";
            this.lbxShops.Size = new System.Drawing.Size(174, 148);
            this.lbxShops.TabIndex = 0;
            // 
            // btnMoneymade
            // 
            this.btnMoneymade.Location = new System.Drawing.Point(225, 43);
            this.btnMoneymade.Name = "btnMoneymade";
            this.btnMoneymade.Size = new System.Drawing.Size(98, 67);
            this.btnMoneymade.TabIndex = 1;
            this.btnMoneymade.Text = "Show Total Money Made";
            this.btnMoneymade.UseVisualStyleBackColor = true;
            this.btnMoneymade.Click += new System.EventHandler(this.btnMoneymade_Click);
            // 
            // lblMoneymade
            // 
            this.lblMoneymade.AutoSize = true;
            this.lblMoneymade.Location = new System.Drawing.Point(222, 144);
            this.lblMoneymade.Name = "lblMoneymade";
            this.lblMoneymade.Size = new System.Drawing.Size(89, 17);
            this.lblMoneymade.TabIndex = 4;
            this.lblMoneymade.Text = "Money made";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(6, 23);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(38, 17);
            this.lblItemID.TabIndex = 5;
            this.lblItemID.Text = "Item:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbItem);
            this.groupBox5.Controls.Add(this.lblAmountsold);
            this.groupBox5.Controls.Add(this.btnAmountsold);
            this.groupBox5.Controls.Add(this.lblItemID);
            this.groupBox5.Location = new System.Drawing.Point(9, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Shop Items";
            // 
            // btnAmountsold
            // 
            this.btnAmountsold.Location = new System.Drawing.Point(6, 49);
            this.btnAmountsold.Name = "btnAmountsold";
            this.btnAmountsold.Size = new System.Drawing.Size(165, 39);
            this.btnAmountsold.TabIndex = 4;
            this.btnAmountsold.Text = "Show Amount Sold";
            this.btnAmountsold.UseVisualStyleBackColor = true;
            // 
            // lblAmountsold
            // 
            this.lblAmountsold.AutoSize = true;
            this.lblAmountsold.Location = new System.Drawing.Point(213, 49);
            this.lblAmountsold.Name = "lblAmountsold";
            this.lblAmountsold.Size = new System.Drawing.Size(88, 17);
            this.lblAmountsold.TabIndex = 4;
            this.lblAmountsold.Text = "Amount Sold";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(50, 21);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(100, 22);
            this.tbItem.TabIndex = 6;
            // 
            // btnTotalreserved
            // 
            this.btnTotalreserved.Location = new System.Drawing.Point(15, 22);
            this.btnTotalreserved.Name = "btnTotalreserved";
            this.btnTotalreserved.Size = new System.Drawing.Size(132, 48);
            this.btnTotalreserved.TabIndex = 2;
            this.btnTotalreserved.Text = "View Total Reserved Spots";
            this.btnTotalreserved.UseVisualStyleBackColor = true;
            // 
            // btnTotalmoneymade
            // 
            this.btnTotalmoneymade.Location = new System.Drawing.Point(15, 80);
            this.btnTotalmoneymade.Name = "btnTotalmoneymade";
            this.btnTotalmoneymade.Size = new System.Drawing.Size(132, 48);
            this.btnTotalmoneymade.TabIndex = 4;
            this.btnTotalmoneymade.Text = "View Total Money Made at Spots";
            this.btnTotalmoneymade.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Total Amount of Visitors at Spots";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTotalreservedspots
            // 
            this.lblTotalreservedspots.AutoSize = true;
            this.lblTotalreservedspots.Location = new System.Drawing.Point(178, 35);
            this.lblTotalreservedspots.Name = "lblTotalreservedspots";
            this.lblTotalreservedspots.Size = new System.Drawing.Size(145, 17);
            this.lblTotalreservedspots.TabIndex = 6;
            this.lblTotalreservedspots.Text = "Total Reserved Spots";
            // 
            // lblTotalmoneymade
            // 
            this.lblTotalmoneymade.AutoSize = true;
            this.lblTotalmoneymade.Location = new System.Drawing.Point(178, 96);
            this.lblTotalmoneymade.Name = "lblTotalmoneymade";
            this.lblTotalmoneymade.Size = new System.Drawing.Size(125, 17);
            this.lblTotalmoneymade.TabIndex = 7;
            this.lblTotalmoneymade.Text = "Total Money Made";
            // 
            // lblTotalamountvisitors
            // 
            this.lblTotalamountvisitors.AutoSize = true;
            this.lblTotalamountvisitors.Location = new System.Drawing.Point(178, 158);
            this.lblTotalamountvisitors.Name = "lblTotalamountvisitors";
            this.lblTotalamountvisitors.Size = new System.Drawing.Size(158, 17);
            this.lblTotalamountvisitors.TabIndex = 8;
            this.lblTotalamountvisitors.Text = "Total Amount of Visitors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 540);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "EventStatusCheck";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbVisitorID;
        private System.Windows.Forms.Label lblVisitorID;
        private System.Windows.Forms.ListBox lbxVisitorHistory;
        private System.Windows.Forms.Label lblVisitorStatus;
        private System.Windows.Forms.Button btnShowVisitorInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalspent;
        private System.Windows.Forms.Button btnTotalspent;
        private System.Windows.Forms.Label lblTotalbalance;
        private System.Windows.Forms.Button btnTotalbalance;
        private System.Windows.Forms.Label lblTotalvisitors;
        private System.Windows.Forms.Button btnTotalvisitors;
        private System.Windows.Forms.ListBox lbxVisitorspresent;
        private System.Windows.Forms.Button btnShowvisitors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMoneymade;
        private System.Windows.Forms.ListBox lbxShops;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblMoneymade;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Label lblAmountsold;
        private System.Windows.Forms.Button btnAmountsold;
        private System.Windows.Forms.Label lblTotalreservedspots;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTotalmoneymade;
        private System.Windows.Forms.Button btnTotalreserved;
        private System.Windows.Forms.Label lblTotalamountvisitors;
        private System.Windows.Forms.Label lblTotalmoneymade;
    }
}

