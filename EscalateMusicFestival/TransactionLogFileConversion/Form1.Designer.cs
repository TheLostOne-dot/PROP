namespace TransactionLogFileConversion
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
            this.btnStartLog = new System.Windows.Forms.Button();
            this.lbxLogs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStartLog
            // 
            this.btnStartLog.Location = new System.Drawing.Point(12, 12);
            this.btnStartLog.Name = "btnStartLog";
            this.btnStartLog.Size = new System.Drawing.Size(75, 23);
            this.btnStartLog.TabIndex = 0;
            this.btnStartLog.Text = "Start ";
            this.btnStartLog.UseVisualStyleBackColor = true;
            this.btnStartLog.Click += new System.EventHandler(this.btnStartLog_Click);
            // 
            // lbxLogs
            // 
            this.lbxLogs.FormattingEnabled = true;
            this.lbxLogs.Location = new System.Drawing.Point(122, 12);
            this.lbxLogs.Name = "lbxLogs";
            this.lbxLogs.Size = new System.Drawing.Size(176, 420);
            this.lbxLogs.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.lbxLogs);
            this.Controls.Add(this.btnStartLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartLog;
        private System.Windows.Forms.ListBox lbxLogs;
    }
}

