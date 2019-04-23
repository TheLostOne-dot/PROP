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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxItemIDscan = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxIDscan = new System.Windows.Forms.ListBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.lblLoan = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxItemIDscan);
            this.groupBox3.Location = new System.Drawing.Point(426, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 116);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ItemID";
            // 
            // lbxItemIDscan
            // 
            this.lbxItemIDscan.FormattingEnabled = true;
            this.lbxItemIDscan.ItemHeight = 16;
            this.lbxItemIDscan.Location = new System.Drawing.Point(7, 36);
            this.lbxItemIDscan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxItemIDscan.Name = "lbxItemIDscan";
            this.lbxItemIDscan.Size = new System.Drawing.Size(326, 52);
            this.lbxItemIDscan.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(401, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 44);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(221, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 47);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "Open Connection";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxIDscan);
            this.groupBox1.Location = new System.Drawing.Point(22, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 116);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnLoan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxItemIDscan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxIDscan;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Label lblLoan;
    }
}

