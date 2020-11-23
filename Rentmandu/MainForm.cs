using Rentmandu.UserControls;
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
    public partial class MainForm : Form
    {
        Contacts contact = null;
        LogsInfo logs = null;
        public MainForm()
        {
            InitializeComponent();


        }
        private void contactsBtn_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.ContainsKey("Contacts") == false)
            {
                contact = new Contacts();
                mainPanel.Controls.Add(contact);
            }

            contact.BringToFront();
            contact.Visible = true;
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.ContainsKey("LogsInfo") == false)
            {
                logs = new LogsInfo();
                mainPanel.Controls.Add(logs);
            }

            logs.BringToFront();
            logs.Visible = true;

        }
    }
}
