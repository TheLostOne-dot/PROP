namespace LoanStands
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCopiedID = new System.Windows.Forms.Label();
            this.lbxIDscan = new System.Windows.Forms.ListBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.lblLoan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblShopID = new System.Windows.Forms.Label();
            this.tbLoanStandID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(401, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 44);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(221, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 47);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "Open Connection";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCopiedID);
            this.groupBox1.Controls.Add(this.lbxIDscan);
            this.groupBox1.Location = new System.Drawing.Point(22, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 116);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // lblCopiedID
            // 
            this.lblCopiedID.AutoSize = true;
            this.lblCopiedID.Location = new System.Drawing.Point(6, 96);
            this.lblCopiedID.Name = "lblCopiedID";
            this.lblCopiedID.Size = new System.Drawing.Size(46, 17);
            this.lblCopiedID.TabIndex = 37;
            this.lblCopiedID.Text = "label1";
            // 
            // lbxIDscan
            // 
            this.lbxIDscan.FormattingEnabled = true;
            this.lbxIDscan.ItemHeight = 16;
            this.lbxIDscan.Location = new System.Drawing.Point(7, 36);
            this.lbxIDscan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxIDscan.Name = "lbxIDscan";
            this.lbxIDscan.Size = new System.Drawing.Size(327, 52);
            this.lbxIDscan.TabIndex = 6;
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(667, 396);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(111, 36);
            this.btnManual.TabIndex = 34;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(293, 260);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(182, 43);
            this.btnLoan.TabIndex = 33;
            this.btnLoan.Text = "Loan ";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(364, 336);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(56, 17);
            this.lblLoan.TabIndex = 35;
            this.lblLoan.Text = "Loaned";
            this.lblLoan.Click += new System.EventHandler(this.lblLoan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbItemID);
            this.groupBox3.Controls.Add(this.lblItemID);
            this.groupBox3.Controls.Add(this.lblShopID);
            this.groupBox3.Controls.Add(this.tbLoanStandID);
            this.groupBox3.Location = new System.Drawing.Point(438, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 116);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LoanStand/ItemID";
            // 
            // tbItemID
            // 
            this.tbItemID.Location = new System.Drawing.Point(156, 82);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(100, 22);
            this.tbItemID.TabIndex = 33;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(95, 82);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(55, 17);
            this.lblItemID.TabIndex = 31;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblShopID
            // 
            this.lblShopID.AutoSize = true;
            this.lblShopID.Location = new System.Drawing.Point(52, 39);
            this.lblShopID.Name = "lblShopID";
            this.lblShopID.Size = new System.Drawing.Size(98, 17);
            this.lblShopID.TabIndex = 32;
            this.lblShopID.Text = "LoanStand ID:";
            // 
            // tbLoanStandID
            // 
            this.tbLoanStandID.Location = new System.Drawing.Point(156, 36);
            this.tbLoanStandID.Name = "tbLoanStandID";
            this.tbLoanStandID.Size = new System.Drawing.Size(100, 22);
            this.tbLoanStandID.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnLoan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxIDscan;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblShopID;
        private System.Windows.Forms.TextBox tbLoanStandID;
        private System.Windows.Forms.Label lblCopiedID;
        private System.Windows.Forms.TextBox tbItemID;
    }
}

