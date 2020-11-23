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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            usernameTbx.Text = Properties.Settings.Default.Username;
            passwordTbx.Text = Properties.Settings.Default.Password;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTbx.Text) && string.IsNullOrEmpty(passwordTbx.Text))
                {
                    MessageBox.Show("Username or Password is empty.");
                }
                else
                {
                    bool validLogin = db.Instance.LoginUser(usernameTbx.Text.ToLower(), Misc.GenerateSHA256String(passwordTbx.Text));
                    if (validLogin)
                    {
                        Properties.Settings.Default.Username = usernameTbx.Text;
                        Properties.Settings.Default.Password = passwordTbx.Text;
                        Properties.Settings.Default.Save();

                        this.Hide();
                        MainForm dashboard = new MainForm();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
