namespace EventCheckin
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStoreid = new System.Windows.Forms.Button();
            this.lblGeneratedId = new System.Windows.Forms.Label();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbIDe = new System.Windows.Forms.Label();
            this.cbNoticket = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCheckincheckout = new System.Windows.Forms.Label();
            this.lbxNewidscan = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStoreid);
            this.groupBox2.Controls.Add(this.lblGeneratedId);
            this.groupBox2.Controls.Add(this.btnGenerateID);
            this.groupBox2.Location = new System.Drawing.Point(184, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 105);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btnStoreid
            // 
            this.btnStoreid.Location = new System.Drawing.Point(278, 41);
            this.btnStoreid.Name = "btnStoreid";
            this.btnStoreid.Size = new System.Drawing.Size(132, 36);
            this.btnStoreid.TabIndex = 23;
            this.btnStoreid.Text = "Store ID";
            this.btnStoreid.UseVisualStyleBackColor = true;
            // 
            // lblGeneratedId
            // 
            this.lblGeneratedId.AutoSize = true;
            this.lblGeneratedId.Location = new System.Drawing.Point(76, 75);
            this.lblGeneratedId.Name = "lblGeneratedId";
            this.lblGeneratedId.Size = new System.Drawing.Size(25, 17);
            this.lblGeneratedId.TabIndex = 22;
            this.lblGeneratedId.Text = "ID:";
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Location = new System.Drawing.Point(47, 21);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(180, 39);
            this.btnGenerateID.TabIndex = 0;
            this.btnGenerateID.Text = "Generate Ticket #";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(344, 409);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(111, 36);
            this.btnManual.TabIndex = 20;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(411, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 44);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(231, 36);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 47);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "Open Connection";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.lbIDe);
            this.groupBox1.Location = new System.Drawing.Point(32, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 116);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(91, 48);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(162, 22);
            this.tbID.TabIndex = 1;
            // 
            // lbIDe
            // 
            this.lbIDe.AutoSize = true;
            this.lbIDe.Location = new System.Drawing.Point(60, 51);
            this.lbIDe.Name = "lbIDe";
            this.lbIDe.Size = new System.Drawing.Size(25, 17);
            this.lbIDe.TabIndex = 0;
            this.lbIDe.Text = "ID:";
            // 
            // cbNoticket
            // 
            this.cbNoticket.AutoSize = true;
            this.cbNoticket.Location = new System.Drawing.Point(357, 271);
            this.cbNoticket.Name = "cbNoticket";
            this.cbNoticket.Size = new System.Drawing.Size(98, 21);
            this.cbNoticket.TabIndex = 0;
            this.cbNoticket.Text = "No Ticket?";
            this.cbNoticket.UseVisualStyleBackColor = true;
            this.cbNoticket.CheckedChanged += new System.EventHandler(this.cbNoticket_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCheckincheckout);
            this.groupBox3.Controls.Add(this.lbxNewidscan);
            this.groupBox3.Location = new System.Drawing.Point(436, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 116);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New ID";
            // 
            // lblCheckincheckout
            // 
            this.lblCheckincheckout.AutoSize = true;
            this.lblCheckincheckout.Location = new System.Drawing.Point(6, 93);
            this.lblCheckincheckout.Name = "lblCheckincheckout";
            this.lblCheckincheckout.Size = new System.Drawing.Size(152, 17);
            this.lblCheckincheckout.TabIndex = 7;
            this.lblCheckincheckout.Text = "CheckedInCheckedOut";
            // 
            // lbxNewidscan
            // 
            this.lbxNewidscan.FormattingEnabled = true;
            this.lbxNewidscan.ItemHeight = 16;
            this.lbxNewidscan.Location = new System.Drawing.Point(7, 36);
            this.lbxNewidscan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxNewidscan.Name = "lbxNewidscan";
            this.lbxNewidscan.Size = new System.Drawing.Size(326, 52);
            this.lbxNewidscan.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbNoticket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "EventCheckin-Checkout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGeneratedId;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.CheckBox cbNoticket;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxNewidscan;
        private System.Windows.Forms.Label lblCheckincheckout;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbIDe;
        private System.Windows.Forms.Button btnStoreid;
    }
}

