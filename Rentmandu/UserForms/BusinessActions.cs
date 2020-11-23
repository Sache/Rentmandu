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
    public partial class BusinessActions : Form
    {
        public BusinessActions()
        {
            InitializeComponent();
        }

        private void businessSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTbx.Text) || string.IsNullOrEmpty(bussTypeTbx.Text)
                 || string.IsNullOrEmpty(mobileTbx.Text) || string.IsNullOrEmpty(landlineTbx.Text)
                 || string.IsNullOrEmpty(emailTbx.Text) || string.IsNullOrEmpty(panNumberTbx.Text))
            {
                MessageBox.Show("Fill all the requirements.");
            }
            else
            {
                if (string.IsNullOrEmpty(businessActionsGrpBx.Text))
                {
                    MessageBox.Show(db.Instance.AddBusiness(nameTbx.Text, bussTypeTbx.Text, Convert.ToInt64(mobileTbx.Text), Convert.ToInt64(landlineTbx.Text), emailTbx.Text, Convert.ToInt64(panNumberTbx.Text)));
                } 
                else
                {
                    MessageBox.Show(db.Instance.UpdateBusiness(Convert.ToInt32(businessActionsGrpBx.Text), nameTbx.Text, bussTypeTbx.Text, Convert.ToInt64(mobileTbx.Text), Convert.ToInt64(landlineTbx.Text), emailTbx.Text, Convert.ToInt64(panNumberTbx.Text)));
                }
                this.Close();
                    
            }
        }

        public  void  EditBusiness(int id)
        {
            DataTable tb = db.Instance.GetBusiness(id);
            businessActionsGrpBx.Text = tb.Rows[0]["ClientID"].ToString();
            nameTbx.Text = tb.Rows[0]["Name"].ToString();
            bussTypeTbx.Text = tb.Rows[0]["Type"].ToString();
            landlineTbx.Text = tb.Rows[0]["Landline"].ToString();
            mobileTbx.Text = tb.Rows[0]["Mobile"].ToString();
            emailTbx.Text = tb.Rows[0]["Email"].ToString();
            panNumberTbx.Text = tb.Rows[0]["PAN"].ToString();
        }

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.NumbersOnly(sender, e);
        }
    }
}
