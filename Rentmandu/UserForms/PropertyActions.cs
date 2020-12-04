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
    public partial class PropertyActions : Form
    {
        public PropertyActions()
        {
            InitializeComponent();

            using(DataTable dt = db.Instance.PopulateContacts())
            {
                pLandlordTbx.DataSource = dt.DefaultView;
                pLandlordTbx.DisplayMember = "Name";
                pLandlordTbx.ValueMember = "ContactID";
                pLandlordTbx.SelectedIndex = -1;
            }
            
        }

        private void pSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pNameTbx.Text) || string.IsNullOrEmpty(pTypeTbx.Text)
                    || string.IsNullOrEmpty(pLocationTbx.Text) || string.IsNullOrEmpty(pLandlordTbx.Text))
                {
                    MessageBox.Show("Fill all the requirements");
                }
                else
                {
                    if (string.IsNullOrEmpty(propertyGroupBox.Text))
                    {
                        MessageBox.Show(db.Instance.AddProperty(pNameTbx.Text, pTypeTbx.Text, pLocationTbx.Text, pNotesTbx.Text, (int)pLandlordTbx.SelectedValue));
                    }
                    else // Edit
                    {
                        MessageBox.Show(db.Instance.UpdateProperty(Convert.ToInt32(propertyGroupBox.Text), pNameTbx.Text, pTypeTbx.Text, pLocationTbx.Text, pNotesTbx.Text, (int)pLandlordTbx.SelectedValue));
                    }
                }
            }
            catch
            {}
            this.Close();
        }

        public void EditProperty(int id)
        {
            DataTable tb = db.Instance.GetProperty(id);
            propertyGroupBox.Text = tb.Rows[0]["PropertyID"].ToString();
            pNameTbx.Text = tb.Rows[0]["Name"].ToString();
            pTypeTbx.Text = tb.Rows[0]["Type"].ToString();
            pLocationTbx.Text = tb.Rows[0]["Location"].ToString();
            pNotesTbx.Text = tb.Rows[0]["Notes"].ToString();
            pLandlordTbx.Text = tb.Rows[0]["Owner"].ToString();
        }
    }
}
