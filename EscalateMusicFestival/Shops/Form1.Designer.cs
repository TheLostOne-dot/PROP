namespace Shops
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxIDscan = new System.Windows.Forms.ListBox();
            this.btnMakepurchase = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.lblSold = new System.Windows.Forms.Label();
            this.tbShopID = new System.Windows.Forms.TextBox();
            this.lblShopID = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.lblCopiedID = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbItemID);
            this.groupBox3.Controls.Add(this.lblItemID);
            this.groupBox3.Controls.Add(this.lblShopID);
            this.groupBox3.Controls.Add(this.tbShopID);
            this.groupBox3.Location = new System.Drawing.Point(436, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 116);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shop/ItemID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(411, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 44);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(231, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 47);
            this.btnOpen.TabIndex = 23;
            this.btnOpen.Text = "Open Connection";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCopiedID);
            this.groupBox1.Controls.Add(this.lbxIDscan);
            this.groupBox1.Location = new System.Drawing.Point(32, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 116);
            this.groupBox1.TabIndex = 25;
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
            // btnMakepurchase
            // 
            this.btnMakepurchase.Location = new System.Drawing.Point(307, 291);
            this.btnMakepurchase.Name = "btnMakepurchase";
            this.btnMakepurchase.Size = new System.Drawing.Size(182, 43);
            this.btnMakepurchase.TabIndex = 27;
            this.btnMakepurchase.Text = "Make Purchase";
            this.btnMakepurchase.UseVisualStyleBackColor = true;
            this.btnMakepurchase.Click += new System.EventHandler(this.btnMakepurchase_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(677, 402);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(111, 36);
            this.btnManual.TabIndex = 28;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(352, 366);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(36, 17);
            this.lblSold.TabIndex = 30;
            this.lblSold.Text = "Sold";
            // 
            // tbShopID
            // 
            this.tbShopID.Location = new System.Drawing.Point(156, 36);
            this.tbShopID.Name = "tbShopID";
            this.tbShopID.Size = new System.Drawing.Size(100, 22);
            this.tbShopID.TabIndex = 31;
            // 
            // lblShopID
            // 
            this.lblShopID.AutoSize = true;
            this.lblShopID.Location = new System.Drawing.Point(88, 39);
            this.lblShopID.Name = "lblShopID";
            this.lblShopID.Size = new System.Drawing.Size(62, 17);
            this.lblShopID.TabIndex = 32;
            this.lblShopID.Text = "Shop ID:";
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
            // tbItemID
            // 
            this.tbItemID.Location = new System.Drawing.Point(156, 82);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(100, 22);
            this.tbItemID.TabIndex = 33;
            // 
            // lblCopiedID
            // 
            this.lblCopiedID.AutoSize = true;
            this.lblCopiedID.Location = new System.Drawing.Point(6, 93);
            this.lblCopiedID.Name = "lblCopiedID";
            this.lblCopiedID.Size = new System.Drawing.Size(46, 17);
            this.lblCopiedID.TabIndex = 31;
            this.lblCopiedID.Text = "label1";
            this.lblCopiedID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSold);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnMakepurchase);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Shops";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxIDscan;
        private System.Windows.Forms.Button btnMakepurchase;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblShopID;
        private System.Windows.Forms.TextBox tbShopID;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label lblCopiedID;
    }
}

