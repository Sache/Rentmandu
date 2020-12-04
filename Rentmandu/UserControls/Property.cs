using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentmandu.UserForms;

namespace Rentmandu.UserControls
{
    public partial class Property : UserControl
    {
        public Property()
        {
            InitializeComponent();
            GetPropertyData();
        }

        public void GetPropertyData()
        {
            using (DataTable propertydt = db.Instance.PopulatePropertyGridView())
            {
                propertyGridView.DataSource = propertydt;
            }
        }

        private void addPropertyBtn_Click(object sender, EventArgs e)
        {
            PropertyActions propertyOP = new PropertyActions();
            propertyOP.Text = "Create";
            propertyOP.ShowDialog();
            GetPropertyData();
        }

        private void editPropertyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int propNum = Convert.ToInt32(propertyGridView.SelectedRows[0].Cells[0].Value.ToString());
                PropertyActions propertyOP = new PropertyActions();
                propertyOP.Text = "Edit";
                propertyOP.EditProperty(propNum);
                propertyOP.ShowDialog();
                GetPropertyData();
            }
            catch
            {}
        }

        private void deletePropertyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int propNum = Convert.ToInt32(propertyGridView.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Are you sure to delete " + propertyGridView.SelectedRows[0].Cells[1].Value.ToString() + "?",
                    "Delete",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(db.Instance.DeleteProperty(propNum));
                }
                GetPropertyData();
            }
            catch
            { }
        }
    }
}
