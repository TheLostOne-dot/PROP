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
            this.lblVisitorID = new System.Windows.Forms.Label();
            this.tbVisitorID = new System.Windows.Forms.TextBox();
            this.btnShowVisitorInfo = new System.Windows.Forms.Button();
            this.lblVisitorStatus = new System.Windows.Forms.Label();
            this.lbxVisitorHistory = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(313, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor";
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
            // tbVisitorID
            // 
            this.tbVisitorID.Location = new System.Drawing.Point(76, 35);
            this.tbVisitorID.Name = "tbVisitorID";
            this.tbVisitorID.Size = new System.Drawing.Size(100, 22);
            this.tbVisitorID.TabIndex = 2;
            // 
            // btnShowVisitorInfo
            // 
            this.btnShowVisitorInfo.Location = new System.Drawing.Point(76, 75);
            this.btnShowVisitorInfo.Name = "btnShowVisitorInfo";
            this.btnShowVisitorInfo.Size = new System.Drawing.Size(100, 23);
            this.btnShowVisitorInfo.TabIndex = 3;
            this.btnShowVisitorInfo.Text = "Show Info";
            this.btnShowVisitorInfo.UseVisualStyleBackColor = true;
            // 
            // lblVisitorStatus
            // 
            this.lblVisitorStatus.AutoSize = true;
            this.lblVisitorStatus.Location = new System.Drawing.Point(6, 158);
            this.lblVisitorStatus.Name = "lblVisitorStatus";
            this.lblVisitorStatus.Size = new System.Drawing.Size(48, 17);
            this.lblVisitorStatus.TabIndex = 4;
            this.lblVisitorStatus.Text = "Status";
            // 
            // lbxVisitorHistory
            // 
            this.lbxVisitorHistory.FormattingEnabled = true;
            this.lbxVisitorHistory.ItemHeight = 16;
            this.lbxVisitorHistory.Location = new System.Drawing.Point(60, 127);
            this.lbxVisitorHistory.Name = "lbxVisitorHistory";
            this.lbxVisitorHistory.Size = new System.Drawing.Size(231, 84);
            this.lbxVisitorHistory.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "EventStatusCheck";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbVisitorID;
        private System.Windows.Forms.Label lblVisitorID;
        private System.Windows.Forms.ListBox lbxVisitorHistory;
        private System.Windows.Forms.Label lblVisitorStatus;
        private System.Windows.Forms.Button btnShowVisitorInfo;
    }
}

