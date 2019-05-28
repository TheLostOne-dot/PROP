namespace End_of_Event
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
            this.lbxIDscan = new System.Windows.Forms.ListBox();
            this.btnMakeInvalid = new System.Windows.Forms.Button();
            this.btnShowloaneditems = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxLoaneditems = new System.Windows.Forms.ListBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(102, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 44);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(102, 45);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 47);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open Connection";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxIDscan);
            this.groupBox1.Location = new System.Drawing.Point(338, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 116);
            this.groupBox1.TabIndex = 22;
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
            // btnMakeInvalid
            // 
            this.btnMakeInvalid.Location = new System.Drawing.Point(455, 396);
            this.btnMakeInvalid.Name = "btnMakeInvalid";
            this.btnMakeInvalid.Size = new System.Drawing.Size(224, 42);
            this.btnMakeInvalid.TabIndex = 23;
            this.btnMakeInvalid.Text = "Mark as Invalid";
            this.btnMakeInvalid.UseVisualStyleBackColor = true;
            // 
            // btnShowloaneditems
            // 
            this.btnShowloaneditems.Location = new System.Drawing.Point(464, 196);
            this.btnShowloaneditems.Name = "btnShowloaneditems";
            this.btnShowloaneditems.Size = new System.Drawing.Size(185, 45);
            this.btnShowloaneditems.TabIndex = 24;
            this.btnShowloaneditems.Text = "Show Loaned Items";
            this.btnShowloaneditems.UseVisualStyleBackColor = true;
            this.btnShowloaneditems.Click += new System.EventHandler(this.btnShowloaneditems_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxLoaneditems);
            this.groupBox2.Location = new System.Drawing.Point(53, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 217);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // lbxLoaneditems
            // 
            this.lbxLoaneditems.FormattingEnabled = true;
            this.lbxLoaneditems.ItemHeight = 16;
            this.lbxLoaneditems.Location = new System.Drawing.Point(6, 21);
            this.lbxLoaneditems.Name = "lbxLoaneditems";
            this.lbxLoaneditems.Size = new System.Drawing.Size(367, 180);
            this.lbxLoaneditems.TabIndex = 26;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(335, 164);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(102, 17);
            this.lblBalance.TabIndex = 26;
            this.lblBalance.Text = "Visitor Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnShowloaneditems);
            this.Controls.Add(this.btnMakeInvalid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "End-of-Event";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxIDscan;
        private System.Windows.Forms.Button btnMakeInvalid;
        private System.Windows.Forms.Button btnShowloaneditems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxLoaneditems;
        private System.Windows.Forms.Label lblBalance;
    }
}

