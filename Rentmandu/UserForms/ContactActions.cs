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

        private void contactSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTbx.Text) || string.IsNullOrEmpty(phoneTbx.Text) 
                || string.IsNullOrEmpty(landlineTbx.Text) || string.IsNullOrEmpty(emailTbx.Text)
                || string.IsNullOrEmpty(citizenNoTbx.Text) || string.IsNullOrEmpty(issueDistrictTbx.Text))
            {
                MessageBox.Show("Fill all the requirements.");
            }
            else
            {
                string contactId = contactActionsGrpBx.Text;
                if (string.IsNullOrEmpty(contactId))
                { //  Create New Contact Profile
                    MessageBox.Show(db.Instance.AddContact( 
                        nameTbx.Text, 
                        Convert.ToInt64(phoneTbx.Text),
                        Convert.ToInt64(landlineTbx.Text),
                        emailTbx.Text, Convert.ToInt64(citizenNoTbx.Text),
                        issueDistrictTbx.Text,
                        czIssueDate.Value.Date.ToString("dd/MM/yyyy")));
                }
                else
                {
                    MessageBox.Show(db.Instance.UpdateContact(
                       Convert.ToInt32(contactActionsGrpBx.Text),
                       nameTbx.Text, 
                       Convert.ToInt64(phoneTbx.Text), 
                       Convert.ToInt64(landlineTbx.Text), 
                       emailTbx.Text,
                       Convert.ToInt64(citizenNoTbx.Text),
                       issueDistrictTbx.Text,
                       czIssueDate.Value.Date.ToString("dd/MM/yyyy")));
                }
                this.Close();
            }
           
        }

        public void EditContact(int id)
        {
            DataTable tb = db.Instance.GetContact(id);
            contactActionsGrpBx.Text = tb.Rows[0]["ContactID"].ToString();
            nameTbx.Text = tb.Rows[0]["Name"].ToString();
            phoneTbx.Text = tb.Rows[0]["Mobile"].ToString();
            landlineTbx.Text = tb.Rows[0]["Landline"].ToString();
            emailTbx.Text = tb.Rows[0]["Email"].ToString();
            citizenNoTbx.Text = tb.Rows[0]["CitizenshipNo"].ToString();
            issueDistrictTbx.Text = tb.Rows[0]["CZPIssueDistrict"].ToString();
            czIssueDate.Text = tb.Rows[0]["CZPIssueDate"].ToString();
        }

        private void Tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.NumbersOnly(sender, e);
        }
    }
}
