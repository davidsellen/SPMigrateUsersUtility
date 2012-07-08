using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MigrateUsersUtility
{
    public partial class frmResult : Form
    {
        private DomainUsersMigrationUtility utility;
       
        public frmResult(DomainUsersMigrationUtility utility)             
        {
            InitializeComponent();
            lblMigratedUsers.Visible = false;
            lblTotalUsers.Visible = false;
            lblSkipedUsers.Visible = false;
            btnSaveProcessMessages.Visible = false;
            this.utility = utility;
            lblMigratedUsers.Visible = true;
            lblTotalUsers.Visible = true;
            lblSkipedUsers.Visible = true;
            btnSaveProcessMessages.Visible = true;
            lblMigratedUsers.Text = string.Format("Migrated Users: {0}", utility.MigratedUsers);
            lblTotalUsers.Text = string.Format("Total Users: {0}", utility.TotalUsers);
            lblSkipedUsers.Text = string.Format("Skiped Users: {0}", utility.SkipedUsers);

            pictureBox1.Image = utility.MigratedUsers > 0 ? Image.FromFile("Images/Information.png") : Image.FromFile("Images/Error.png");
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void btnSaveProcessMessages_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fileStream = new StreamWriter(saveFileDialog1.FileName, true);
                foreach (var message in utility.Messages)
                {
                    fileStream.WriteLine(message);
                }
                fileStream.Close();
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
