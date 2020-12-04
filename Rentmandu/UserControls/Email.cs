using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentmandu.UserControls
{
    public partial class Email : UserControl
    {
        public Email()
        {
            InitializeComponent();
            smtpServerTbx.Text = Properties.Settings.Default.EmailServer;
            emailPortTbx.Value = Properties.Settings.Default.EmailPort;
            fromEmailTbx.Text = Properties.Settings.Default.Email;
            EmailPasswdTbx.Text = Properties.Settings.Default.EmailPassword;
        }

        private void emailPortTbx_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailPort = (int)emailPortTbx.Value;
            Properties.Settings.Default.Save();
        }

        private void fromEmailTbx_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Email = fromEmailTbx.Text;
            Properties.Settings.Default.Save();
        }

        private void EmailPasswdTbx_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailPassword = EmailPasswdTbx.Text;
            Properties.Settings.Default.Save();

        }

        private void smtpServerTbx_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailServer = smtpServerTbx.Text;
            Properties.Settings.Default.Save();
        }
    }
}
