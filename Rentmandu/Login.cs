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
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(usernameTbx.Text) && string.IsNullOrEmpty(passwordTbx.Text))
            {
                MessageBox.Show("Username or Password is empty.");
            }
            else
            {
                bool validLogin  = db.Instance.LoginUser(usernameTbx.Text.ToLower(), Misc.GenerateSHA256String(passwordTbx.Text));
                if (validLogin)
                {
                    this.Hide();
                    MainForm dashboard = new MainForm();
                    dashboard.Show();
                }
            }
        }
    }
}
