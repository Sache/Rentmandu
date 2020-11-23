using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentmandu
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            hostTbx.Text = Properties.Settings.Default.dbHost;
            usernameTbx.Text = Properties.Settings.Default.dbUsername;
            passwordTbx.Text = Properties.Settings.Default.dbPassword;
            dbNameTbx.Text = Properties.Settings.Default.dbName;
            companyTbx.Text = Properties.Settings.Default.CompanyName;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbHost = hostTbx.Text;
            Properties.Settings.Default.dbUsername = usernameTbx.Text;
            Properties.Settings.Default.dbPassword = passwordTbx.Text;
            Properties.Settings.Default.dbName = dbNameTbx.Text;
            Properties.Settings.Default.CompanyName = companyTbx.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("OK",string.Empty,buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

        }
    }
}
