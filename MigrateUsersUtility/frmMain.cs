using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MigrateUsersUtility
{
    public partial class frmMain : Form
    {
        private string siteCollectionUrl;
        private string oldDomainName;
        private string newDomainName;
        private bool ignorySidHistory;
        private DomainUsersMigrationUtility utility;

        public frmMain()
        {
            InitializeComponent();
            picAnimation.Image = Image.FromFile("Images/Animation.gif");
            picAnimation.Width = picAnimation.Image.Width;
            picAnimation.Height = picAnimation.Image.Height;
            picAnimation.BackColor = Color.Transparent;
            pnlExecuting.Visible = false;
            this.Icon = new Icon("Images/MigrateUsersUtility.ico");
            tbxSiteCollectionAddress.Focus();
        }

        private void btnDoMigrate_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                this.Cursor = Cursors.WaitCursor;
                pnlExecuting.Visible = true;
                pnlExecuting.BringToFront();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            siteCollectionUrl = tbxSiteCollectionAddress.Text;
            oldDomainName = tbxOldDomainName.Text;
            newDomainName = tbxNewDomainName.Text;
            ignorySidHistory = rbYes.Checked;
            var migrationUtilityRequest = new DomainUsersMigrationRequest
            {
                EnforceSidHistory = ignorySidHistory,
                SiteCollectionUrl = siteCollectionUrl,
                OldDomainName = oldDomainName,
                NewDomainName = newDomainName
            };
            utility = new DomainUsersMigrationUtility(migrationUtilityRequest);
            utility.Start();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlExecuting.Visible = false;
            this.Cursor = Cursors.Default;
            if (!(e.Error == null))
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {
                var frmResult = new frmResult(utility);
                frmResult.ShowDialog(this);
            }
        }
    }
}
