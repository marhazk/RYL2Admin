namespace RYL2Admin
{
    partial class Main
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
                dns.DisposeAll();
                dns.Dispose();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstLogError = new System.Windows.Forms.ListBox();
            this.mIP = new System.Windows.Forms.TextBox();
            this.mNStatus = new System.Windows.Forms.TextBox();
            this.mGStatus = new System.Windows.Forms.TextBox();
            this.mLStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstIP = new System.Windows.Forms.ListBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.bExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bExit);
            this.tabPage1.Controls.Add(this.lstLogError);
            this.tabPage1.Controls.Add(this.mIP);
            this.tabPage1.Controls.Add(this.mNStatus);
            this.tabPage1.Controls.Add(this.mGStatus);
            this.tabPage1.Controls.Add(this.mLStatus);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstIP);
            this.tabPage1.Controls.Add(this.lstLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstLogError
            // 
            this.lstLogError.FormattingEnabled = true;
            this.lstLogError.Location = new System.Drawing.Point(382, 14);
            this.lstLogError.Name = "lstLogError";
            this.lstLogError.Size = new System.Drawing.Size(160, 160);
            this.lstLogError.TabIndex = 10;
            // 
            // mIP
            // 
            this.mIP.Location = new System.Drawing.Point(382, 286);
            this.mIP.Name = "mIP";
            this.mIP.Size = new System.Drawing.Size(160, 20);
            this.mIP.TabIndex = 9;
            // 
            // mNStatus
            // 
            this.mNStatus.Location = new System.Drawing.Point(98, 286);
            this.mNStatus.Name = "mNStatus";
            this.mNStatus.Size = new System.Drawing.Size(147, 20);
            this.mNStatus.TabIndex = 8;
            // 
            // mGStatus
            // 
            this.mGStatus.Location = new System.Drawing.Point(98, 258);
            this.mGStatus.Name = "mGStatus";
            this.mGStatus.Size = new System.Drawing.Size(147, 20);
            this.mGStatus.TabIndex = 7;
            // 
            // mLStatus
            // 
            this.mLStatus.Location = new System.Drawing.Point(98, 229);
            this.mLStatus.Name = "mLStatus";
            this.mLStatus.Size = new System.Drawing.Size(147, 20);
            this.mLStatus.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Network Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game Status :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LAC Status :";
            // 
            // lstIP
            // 
            this.lstIP.FormattingEnabled = true;
            this.lstIP.Location = new System.Drawing.Point(382, 180);
            this.lstIP.Name = "lstIP";
            this.lstIP.Size = new System.Drawing.Size(160, 95);
            this.lstIP.TabIndex = 1;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(6, 15);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(370, 160);
            this.lstLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstProcesses);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proccesses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstProcesses
            // 
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.Location = new System.Drawing.Point(6, 13);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(233, 290);
            this.lstProcesses.TabIndex = 1;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(170, 200);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 11;
            this.bExit.Text = "E&xit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "RYL2Admin Management";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox mIP;
        public System.Windows.Forms.TextBox mNStatus;
        public System.Windows.Forms.TextBox mGStatus;
        public System.Windows.Forms.TextBox mLStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lstIP;
        public System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListBox lstProcesses;
        public System.Windows.Forms.ListBox lstLogError;
        private System.Windows.Forms.Button bExit;
    }
}

