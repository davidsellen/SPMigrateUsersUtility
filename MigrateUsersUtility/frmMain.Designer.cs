namespace MigrateUsersUtility
{
    partial class frmMain
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
            this.btnDoMigrate = new System.Windows.Forms.Button();
            this.lblSiteCollection = new System.Windows.Forms.Label();
            this.tbxSiteCollectionAddress = new System.Windows.Forms.TextBox();
            this.tbxOldDomainName = new System.Windows.Forms.TextBox();
            this.lblOldDomain = new System.Windows.Forms.Label();
            this.tbxNewDomainName = new System.Windows.Forms.TextBox();
            this.lblNewDomainName = new System.Windows.Forms.Label();
            this.lblIgnoreSidHistory = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.pnlExecuting = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picAnimation = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlExecuting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoMigrate
            // 
            this.btnDoMigrate.Location = new System.Drawing.Point(16, 211);
            this.btnDoMigrate.Name = "btnDoMigrate";
            this.btnDoMigrate.Size = new System.Drawing.Size(264, 40);
            this.btnDoMigrate.TabIndex = 5;
            this.btnDoMigrate.Text = "Migrate Users";
            this.btnDoMigrate.UseVisualStyleBackColor = true;
            this.btnDoMigrate.Click += new System.EventHandler(this.btnDoMigrate_Click);
            // 
            // lblSiteCollection
            // 
            this.lblSiteCollection.AutoSize = true;
            this.lblSiteCollection.Location = new System.Drawing.Point(13, 13);
            this.lblSiteCollection.Name = "lblSiteCollection";
            this.lblSiteCollection.Size = new System.Drawing.Size(135, 13);
            this.lblSiteCollection.TabIndex = 1;
            this.lblSiteCollection.Text = "Type the site collection Url:";
            // 
            // tbxSiteCollectionAddress
            // 
            this.tbxSiteCollectionAddress.Location = new System.Drawing.Point(16, 30);
            this.tbxSiteCollectionAddress.Name = "tbxSiteCollectionAddress";
            this.tbxSiteCollectionAddress.Size = new System.Drawing.Size(264, 20);
            this.tbxSiteCollectionAddress.TabIndex = 0;
            // 
            // tbxOldDomainName
            // 
            this.tbxOldDomainName.Location = new System.Drawing.Point(16, 70);
            this.tbxOldDomainName.Name = "tbxOldDomainName";
            this.tbxOldDomainName.Size = new System.Drawing.Size(264, 20);
            this.tbxOldDomainName.TabIndex = 1;
            // 
            // lblOldDomain
            // 
            this.lblOldDomain.AutoSize = true;
            this.lblOldDomain.Location = new System.Drawing.Point(13, 53);
            this.lblOldDomain.Name = "lblOldDomain";
            this.lblOldDomain.Size = new System.Drawing.Size(96, 13);
            this.lblOldDomain.TabIndex = 3;
            this.lblOldDomain.Text = "Old Domain Name:";
            // 
            // tbxNewDomainName
            // 
            this.tbxNewDomainName.Location = new System.Drawing.Point(16, 115);
            this.tbxNewDomainName.Name = "tbxNewDomainName";
            this.tbxNewDomainName.Size = new System.Drawing.Size(264, 20);
            this.tbxNewDomainName.TabIndex = 2;
            // 
            // lblNewDomainName
            // 
            this.lblNewDomainName.AutoSize = true;
            this.lblNewDomainName.Location = new System.Drawing.Point(13, 98);
            this.lblNewDomainName.Name = "lblNewDomainName";
            this.lblNewDomainName.Size = new System.Drawing.Size(102, 13);
            this.lblNewDomainName.TabIndex = 5;
            this.lblNewDomainName.Text = "New Domain Name:";
            // 
            // lblIgnoreSidHistory
            // 
            this.lblIgnoreSidHistory.AutoSize = true;
            this.lblIgnoreSidHistory.Location = new System.Drawing.Point(13, 147);
            this.lblIgnoreSidHistory.Name = "lblIgnoreSidHistory";
            this.lblIgnoreSidHistory.Size = new System.Drawing.Size(100, 13);
            this.lblIgnoreSidHistory.TabIndex = 7;
            this.lblIgnoreSidHistory.Text = "Enforce Sid History:";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(16, 172);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 3;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(65, 172);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 4;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // pnlExecuting
            // 
            this.pnlExecuting.Controls.Add(this.picAnimation);
            this.pnlExecuting.Controls.Add(this.label1);
            this.pnlExecuting.Location = new System.Drawing.Point(16, 195);
            this.pnlExecuting.Name = "pnlExecuting";
            this.pnlExecuting.Size = new System.Drawing.Size(264, 56);
            this.pnlExecuting.TabIndex = 8;
            this.pnlExecuting.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(87, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Migrating users...";
            // 
            // picAnimation
            // 
            this.picAnimation.Location = new System.Drawing.Point(24, 4);
            this.picAnimation.Name = "picAnimation";
            this.picAnimation.Size = new System.Drawing.Size(48, 48);
            this.picAnimation.TabIndex = 1;
            this.picAnimation.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 263);
            this.Controls.Add(this.pnlExecuting);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lblIgnoreSidHistory);
            this.Controls.Add(this.tbxNewDomainName);
            this.Controls.Add(this.lblNewDomainName);
            this.Controls.Add(this.tbxOldDomainName);
            this.Controls.Add(this.lblOldDomain);
            this.Controls.Add(this.tbxSiteCollectionAddress);
            this.Controls.Add(this.lblSiteCollection);
            this.Controls.Add(this.btnDoMigrate);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Migrate Site Domain Users Tool";
            this.pnlExecuting.ResumeLayout(false);
            this.pnlExecuting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoMigrate;
        private System.Windows.Forms.Label lblSiteCollection;
        private System.Windows.Forms.TextBox tbxSiteCollectionAddress;
        private System.Windows.Forms.TextBox tbxOldDomainName;
        private System.Windows.Forms.Label lblOldDomain;
        private System.Windows.Forms.TextBox tbxNewDomainName;
        private System.Windows.Forms.Label lblNewDomainName;
        private System.Windows.Forms.Label lblIgnoreSidHistory;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Panel pnlExecuting;
        private System.Windows.Forms.PictureBox picAnimation;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;        
    }
}

