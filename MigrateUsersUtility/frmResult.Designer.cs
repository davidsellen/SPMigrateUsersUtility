namespace MigrateUsersUtility
{
    partial class frmResult
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
            this.btnSaveProcessMessages = new System.Windows.Forms.Button();
            this.lblSkipedUsers = new System.Windows.Forms.Label();
            this.lblMigratedUsers = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveProcessMessages
            // 
            this.btnSaveProcessMessages.Location = new System.Drawing.Point(12, 78);
            this.btnSaveProcessMessages.Name = "btnSaveProcessMessages";
            this.btnSaveProcessMessages.Size = new System.Drawing.Size(123, 39);
            this.btnSaveProcessMessages.TabIndex = 17;
            this.btnSaveProcessMessages.Text = "Save Log";
            this.btnSaveProcessMessages.UseVisualStyleBackColor = true;
            this.btnSaveProcessMessages.Click += new System.EventHandler(this.btnSaveProcessMessages_Click);
            // 
            // lblSkipedUsers
            // 
            this.lblSkipedUsers.AutoSize = true;
            this.lblSkipedUsers.Location = new System.Drawing.Point(14, 52);
            this.lblSkipedUsers.Name = "lblSkipedUsers";
            this.lblSkipedUsers.Size = new System.Drawing.Size(73, 13);
            this.lblSkipedUsers.TabIndex = 16;
            this.lblSkipedUsers.Text = "Skiped Users:";
            // 
            // lblMigratedUsers
            // 
            this.lblMigratedUsers.AutoSize = true;
            this.lblMigratedUsers.Location = new System.Drawing.Point(14, 30);
            this.lblMigratedUsers.Name = "lblMigratedUsers";
            this.lblMigratedUsers.Size = new System.Drawing.Size(81, 13);
            this.lblMigratedUsers.TabIndex = 15;
            this.lblMigratedUsers.Text = "Migrated Users:";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Location = new System.Drawing.Point(14, 8);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(64, 13);
            this.lblTotalUsers.TabIndex = 14;
            this.lblTotalUsers.Text = "Total Users:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(142, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 39);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 129);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveProcessMessages);
            this.Controls.Add(this.lblSkipedUsers);
            this.Controls.Add(this.lblMigratedUsers);
            this.Controls.Add(this.lblTotalUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Migration info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveProcessMessages;
        private System.Windows.Forms.Label lblSkipedUsers;
        private System.Windows.Forms.Label lblMigratedUsers;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}