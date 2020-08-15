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

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTbx.Text) && string.IsNullOrEmpty(bussTypeTbx.Text)
                 && string.IsNullOrEmpty(mobileTbx.Text) && string.IsNullOrEmpty(landlineTbx.Text)
                 && string.IsNullOrEmpty(emailTbx.Text) && string.IsNullOrEmpty(panNumberTbx.Text))
            {
                MessageBox.Show("Fill all the requirements.");
            }
            else
            {
                MessageBox.Show(db.Instance.AddBusiness(nameTbx.Text, bussTypeTbx.Text, Convert.ToInt64(mobileTbx.Text), Convert.ToInt64(landlineTbx.Text), emailTbx.Text, Convert.ToInt64(panNumberTbx.Text)));
            }
        }

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.NumbersOnly(sender, e);
        }
    }
}
