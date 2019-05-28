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
            this.btnVisitorsinfo = new System.Windows.Forms.Button();
            this.lbxVisitorspresent = new System.Windows.Forms.ListBox();
            this.btnShowvisitors = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxCampingstats = new System.Windows.Forms.ListBox();
            this.btnCampstats = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.lblAmountsold = new System.Windows.Forms.Label();
            this.btnAmountsold = new System.Windows.Forms.Button();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblMoneymade = new System.Windows.Forms.Label();
            this.btnMoneymade = new System.Windows.Forms.Button();
            this.lbxShops = new System.Windows.Forms.ListBox();
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbxVisitorHistory
            // 
            this.lbxVisitorHistory.FormattingEnabled = true;
            this.lbxVisitorHistory.ItemHeight = 16;
            this.lbxVisitorHistory.Location = new System.Drawing.Point(6, 129);
            this.lbxVisitorHistory.Name = "lbxVisitorHistory";
            this.lbxVisitorHistory.Size = new System.Drawing.Size(346, 84);
            this.lbxVisitorHistory.TabIndex = 5;
            // 
            // lblVisitorStatus
            // 
            this.lblVisitorStatus.AutoSize = true;
            this.lblVisitorStatus.Location = new System.Drawing.Point(261, 92);
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
            this.btnShowVisitorInfo.Click += new System.EventHandler(this.btnShowVisitorInfo_Click);
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
            this.groupBox2.Controls.Add(this.btnVisitorsinfo);
            this.groupBox2.Controls.Add(this.lbxVisitorspresent);
            this.groupBox2.Controls.Add(this.btnShowvisitors);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitors";
            // 
            // btnVisitorsinfo
            // 
            this.btnVisitorsinfo.Location = new System.Drawing.Point(202, 43);
            this.btnVisitorsinfo.Name = "btnVisitorsinfo";
            this.btnVisitorsinfo.Size = new System.Drawing.Size(107, 48);
            this.btnVisitorsinfo.TabIndex = 6;
            this.btnVisitorsinfo.Text = "View Visitors\' Statistics";
            this.btnVisitorsinfo.UseVisualStyleBackColor = true;
            this.btnVisitorsinfo.Click += new System.EventHandler(this.btnVisitorsinfo_Click);
            // 
            // lbxVisitorspresent
            // 
            this.lbxVisitorspresent.FormattingEnabled = true;
            this.lbxVisitorspresent.ItemHeight = 16;
            this.lbxVisitorspresent.Location = new System.Drawing.Point(10, 109);
            this.lbxVisitorspresent.Name = "lbxVisitorspresent";
            this.lbxVisitorspresent.Size = new System.Drawing.Size(342, 164);
            this.lbxVisitorspresent.TabIndex = 2;
            // 
            // btnShowvisitors
            // 
            this.btnShowvisitors.Location = new System.Drawing.Point(36, 43);
            this.btnShowvisitors.Name = "btnShowvisitors";
            this.btnShowvisitors.Size = new System.Drawing.Size(110, 48);
            this.btnShowvisitors.TabIndex = 0;
            this.btnShowvisitors.Text = "Show Visitors Present";
            this.btnShowvisitors.UseVisualStyleBackColor = true;
            this.btnShowvisitors.Click += new System.EventHandler(this.btnShowvisitors_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxCampingstats);
            this.groupBox3.Controls.Add(this.btnCampstats);
            this.groupBox3.Location = new System.Drawing.Point(376, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camping Spots";
            // 
            // lbxCampingstats
            // 
            this.lbxCampingstats.FormattingEnabled = true;
            this.lbxCampingstats.ItemHeight = 16;
            this.lbxCampingstats.Location = new System.Drawing.Point(30, 92);
            this.lbxCampingstats.Name = "lbxCampingstats";
            this.lbxCampingstats.Size = new System.Drawing.Size(346, 132);
            this.lbxCampingstats.TabIndex = 10;
            // 
            // btnCampstats
            // 
            this.btnCampstats.Location = new System.Drawing.Point(123, 35);
            this.btnCampstats.Name = "btnCampstats";
            this.btnCampstats.Size = new System.Drawing.Size(163, 51);
            this.btnCampstats.TabIndex = 9;
            this.btnCampstats.Text = "View Camping Statistics";
            this.btnCampstats.UseVisualStyleBackColor = true;
            this.btnCampstats.Click += new System.EventHandler(this.btnCampstats_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.lblMoneymade);
            this.groupBox4.Controls.Add(this.btnMoneymade);
            this.groupBox4.Controls.Add(this.lbxShops);
            this.groupBox4.Location = new System.Drawing.Point(376, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 281);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stands";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbItem);
            this.groupBox5.Controls.Add(this.lblAmountsold);
            this.groupBox5.Controls.Add(this.btnAmountsold);
            this.groupBox5.Controls.Add(this.lblItemID);
            this.groupBox5.Location = new System.Drawing.Point(9, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(391, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Shop Items";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(50, 21);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(100, 22);
            this.tbItem.TabIndex = 6;
            // 
            // lblAmountsold
            // 
            this.lblAmountsold.AutoSize = true;
            this.lblAmountsold.Location = new System.Drawing.Point(178, 49);
            this.lblAmountsold.Name = "lblAmountsold";
            this.lblAmountsold.Size = new System.Drawing.Size(88, 17);
            this.lblAmountsold.TabIndex = 4;
            this.lblAmountsold.Text = "Amount Sold";
            // 
            // btnAmountsold
            // 
            this.btnAmountsold.Location = new System.Drawing.Point(6, 49);
            this.btnAmountsold.Name = "btnAmountsold";
            this.btnAmountsold.Size = new System.Drawing.Size(165, 39);
            this.btnAmountsold.TabIndex = 4;
            this.btnAmountsold.Text = "Show Amount Sold";
            this.btnAmountsold.UseVisualStyleBackColor = true;
            this.btnAmountsold.Click += new System.EventHandler(this.btnAmountsold_Click);
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
            // lblMoneymade
            // 
            this.lblMoneymade.AutoSize = true;
            this.lblMoneymade.Location = new System.Drawing.Point(186, 123);
            this.lblMoneymade.Name = "lblMoneymade";
            this.lblMoneymade.Size = new System.Drawing.Size(89, 17);
            this.lblMoneymade.TabIndex = 4;
            this.lblMoneymade.Text = "Money made";
            // 
            // btnMoneymade
            // 
            this.btnMoneymade.Location = new System.Drawing.Point(235, 24);
            this.btnMoneymade.Name = "btnMoneymade";
            this.btnMoneymade.Size = new System.Drawing.Size(122, 86);
            this.btnMoneymade.TabIndex = 1;
            this.btnMoneymade.Text = "Show Total Amount of Money Made";
            this.btnMoneymade.UseVisualStyleBackColor = true;
            this.btnMoneymade.Click += new System.EventHandler(this.btnMoneymade_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 540);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "EventStatusCheck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lbxCampingstats;
        private System.Windows.Forms.Button btnCampstats;
        private System.Windows.Forms.Button btnVisitorsinfo;
    }
}

