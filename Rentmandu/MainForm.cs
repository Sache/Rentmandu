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
        Property property = null;
        public MainForm()
        {
            InitializeComponent();


        }
        private void contactsBtn_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.ContainsKey("Contacts"))
                mainPanel.Controls.Remove(contact);

            contact = new Contacts();
            mainPanel.Controls.Add(contact);
            contact.BringToFront();
            contact.Visible = true;
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.ContainsKey("LogsInfo"))
                mainPanel.Controls.Remove(logs);

            logs = new LogsInfo();
            mainPanel.Controls.Add(logs);
            logs.BringToFront();
            logs.Visible = true;

        }

        private void propertyButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.ContainsKey("Property"))
                mainPanel.Controls.Remove(property);

            property = new Property();
            mainPanel.Controls.Add(property);
            property.BringToFront();
            property.Visible = true;

        }
    }
}
