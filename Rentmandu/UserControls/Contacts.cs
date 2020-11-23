﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentmandu.UserForms;
using MySql.Data.MySqlClient;

namespace Rentmandu.UserControls
{
    public partial class Contacts : UserControl
    {
        public Contacts()
        {
            InitializeComponent();
            GetContactsData();
            GetBusinessData();
        }

        private void addBusinessBtn_Click(object sender, EventArgs e)
        {
            BusinessActions businessOP = new BusinessActions();
            businessOP.Text = "Create";
            businessOP.ShowDialog();
            GetBusinessData();
        }

        private void addContactBtn_Click(object sender, EventArgs e)
        {
            ContactActions contactOP = new ContactActions();
            contactOP.Text = "Create";
            contactOP.ShowDialog();
            GetContactsData();
        }

        private void contactsEditBtn_Click(object sender, EventArgs e)
        {
            ContactActions contactOP = new ContactActions();
            contactOP.Text = "Edit";
            contactOP.EditContact(Convert.ToInt32(contactID.Text));
            contactOP.ShowDialog();
            GetContactsData();
        }

        private void businessEditBtn_Click(object sender, EventArgs e)
        {
            BusinessActions businessOP = new BusinessActions();
            businessOP.EditBusiness(Convert.ToInt32(businessNumber.Text));
            businessOP.Text = "Edit";
            businessOP.ShowDialog();
            GetBusinessData();
        }

        private void deleteContactsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete " + contactName.Text + "?",
            "Delete",
            MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(db.Instance.DeleteContact(Convert.ToInt32(contactID.Text)));
            }
            GetContactsData();
        }

        private void businessDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete " + companyName.Text+ "?",
                "Delete",
                MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show(db.Instance.DeleteBusiness(Convert.ToInt32(businessNumber.Text)));
            }
            GetBusinessData();
        }
        public void GetContactsData()
        {
            using (DataTable contactdt = db.Instance.PopulateContactsGridView())
            {
                contactsGridVew.DataSource = contactdt;
                contactsGridVew.Columns["ContactID"].Visible = false;
                contactsGridVew.Columns["CitizenshipNo"].HeaderText = "Citizenship";
                contactsGridVew.Columns["CZPIssueDistrict"].HeaderText = "Issue District";
                contactsGridVew.Columns["CZPIssueDate"].HeaderText = "Issue Date";
            }

        }

        private void GetBusinessData()
        {
            using (DataTable contactdt = db.Instance.PopulateBusinessGridView())
            {
                businessGridview.DataSource = contactdt;
                businessGridview.Columns["ClientID"].Visible = false;
            }

        }
        private void contactsGridVew_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow test = contactsGridVew.CurrentRow;
            contactID.Text = test.Cells[0].Value.ToString();
            contactName.Text = test.Cells[1].Value.ToString();
            contactNumber.Text = test.Cells[2].Value.ToString();
            contactLandline.Text = test.Cells[3].Value.ToString();
            contactEmail.Text = test.Cells[4].Value.ToString();
            CZPNumber.Text = test.Cells[5].Value.ToString();
            CZPIssueDistrict.Text = test.Cells[6].Value.ToString();
            CZPIssueDate.Text = test.Cells[7].Value.ToString();
        }

        private void businessGridview_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow test = businessGridview.CurrentRow;
            businessNumber.Text = test.Cells[0].Value.ToString();
            companyName.Text = test.Cells[1].Value.ToString();
            businessType.Text = test.Cells[2].Value.ToString();
            bussMobileNumber.Text = test.Cells[3].Value.ToString();
            BussLandlineNumber.Text = test.Cells[4].Value.ToString();
            businessEmail.Text = test.Cells[5].Value.ToString();
            PANNumber.Text = test.Cells[6].Value.ToString();
        }

    }
}
