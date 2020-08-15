using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentmandu.UserForms
{
    public partial class ContactActions : Form
    {
        public ContactActions()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTbx.Text) && string.IsNullOrEmpty(phoneTbx.Text) 
                && string.IsNullOrEmpty(landlineTbx.Text) && string.IsNullOrEmpty(emailTbx.Text)
                && string.IsNullOrEmpty(citizenNoTbx.Text) && string.IsNullOrEmpty(issueDistrictTbx.Text))
            {
                MessageBox.Show("Fill all the requirements.");
            }
            else
            {
                MessageBox.Show(db.Instance.AddContact( //  Create New Contact Profile
                    nameTbx.Text, Convert.ToInt64(phoneTbx.Text), Convert.ToInt64(landlineTbx.Text), emailTbx.Text, Convert.ToInt64(citizenNoTbx.Text), issueDistrictTbx.Text, dateTimePicker1.Value.Date.ToString("dd/MM/yyyy")));
            }
           
        }

        private void Tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.NumbersOnly(sender, e);
        }
    }
}
