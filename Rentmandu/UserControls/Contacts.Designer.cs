namespace Rentmandu.UserControls
{
    partial class Contacts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.viewGroupBx = new System.Windows.Forms.GroupBox();
            this.deleteContactsBtn = new System.Windows.Forms.Button();
            this.contactsEditBtn = new System.Windows.Forms.Button();
            this.addContactBtn = new System.Windows.Forms.Button();
            this.contactID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contactEmail = new System.Windows.Forms.Label();
            this.contactLandline = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.contactName = new System.Windows.Forms.Label();
            this.citizenshipGrpBx = new System.Windows.Forms.GroupBox();
            this.CZPIssueDate = new System.Windows.Forms.Label();
            this.CZPIssueDistrict = new System.Windows.Forms.Label();
            this.CZPNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CZPIssueDatelbl = new System.Windows.Forms.Label();
            this.CZPIssueDistrictlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.contactsGridVew = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.displayGrpTbx = new System.Windows.Forms.GroupBox();
            this.businessType = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.businessDeleteBtn = new System.Windows.Forms.Button();
            this.businessEditBtn = new System.Windows.Forms.Button();
            this.businessNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addBusinessBtn = new System.Windows.Forms.Button();
            this.businessEmail = new System.Windows.Forms.Label();
            this.BussLandlineNumber = new System.Windows.Forms.Label();
            this.bussMobileNumber = new System.Windows.Forms.Label();
            this.PANNumber = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.landlineLbl = new System.Windows.Forms.Label();
            this.mobileLbl = new System.Windows.Forms.Label();
            this.PanTbx = new System.Windows.Forms.Label();
            this.clientNameLbl = new System.Windows.Forms.Label();
            this.businessGridview = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            this.viewGroupBx.SuspendLayout();
            this.citizenshipGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridVew)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.displayGrpTbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.viewGroupBx);
            this.tabPage2.Controls.Add(this.contactsGridVew);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1103, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contacts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // viewGroupBx
            // 
            this.viewGroupBx.Controls.Add(this.deleteContactsBtn);
            this.viewGroupBx.Controls.Add(this.contactsEditBtn);
            this.viewGroupBx.Controls.Add(this.addContactBtn);
            this.viewGroupBx.Controls.Add(this.contactID);
            this.viewGroupBx.Controls.Add(this.label5);
            this.viewGroupBx.Controls.Add(this.contactEmail);
            this.viewGroupBx.Controls.Add(this.contactLandline);
            this.viewGroupBx.Controls.Add(this.contactNumber);
            this.viewGroupBx.Controls.Add(this.contactName);
            this.viewGroupBx.Controls.Add(this.citizenshipGrpBx);
            this.viewGroupBx.Controls.Add(this.label3);
            this.viewGroupBx.Controls.Add(this.label2);
            this.viewGroupBx.Controls.Add(this.label1);
            this.viewGroupBx.Controls.Add(this.nameLbl);
            this.viewGroupBx.Location = new System.Drawing.Point(7, 7);
            this.viewGroupBx.Name = "viewGroupBx";
            this.viewGroupBx.Size = new System.Drawing.Size(1091, 231);
            this.viewGroupBx.TabIndex = 2;
            this.viewGroupBx.TabStop = false;
            this.viewGroupBx.Text = "View";
            // 
            // deleteContactsBtn
            // 
            this.deleteContactsBtn.Image = global::Rentmandu.Properties.Resources.minus;
            this.deleteContactsBtn.Location = new System.Drawing.Point(1030, 132);
            this.deleteContactsBtn.Name = "deleteContactsBtn";
            this.deleteContactsBtn.Size = new System.Drawing.Size(46, 42);
            this.deleteContactsBtn.TabIndex = 29;
            this.deleteContactsBtn.UseVisualStyleBackColor = true;
            this.deleteContactsBtn.Click += new System.EventHandler(this.deleteContactsBtn_Click);
            // 
            // contactsEditBtn
            // 
            this.contactsEditBtn.Image = global::Rentmandu.Properties.Resources.edit;
            this.contactsEditBtn.Location = new System.Drawing.Point(1030, 84);
            this.contactsEditBtn.Name = "contactsEditBtn";
            this.contactsEditBtn.Size = new System.Drawing.Size(46, 42);
            this.contactsEditBtn.TabIndex = 28;
            this.contactsEditBtn.UseVisualStyleBackColor = true;
            this.contactsEditBtn.Click += new System.EventHandler(this.contactsEditBtn_Click);
            // 
            // addContactBtn
            // 
            this.addContactBtn.Image = ((System.Drawing.Image)(resources.GetObject("addContactBtn.Image")));
            this.addContactBtn.Location = new System.Drawing.Point(1030, 31);
            this.addContactBtn.Name = "addContactBtn";
            this.addContactBtn.Size = new System.Drawing.Size(46, 47);
            this.addContactBtn.TabIndex = 27;
            this.addContactBtn.UseVisualStyleBackColor = true;
            this.addContactBtn.Click += new System.EventHandler(this.addContactBtn_Click);
            // 
            // contactID
            // 
            this.contactID.AutoSize = true;
            this.contactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.contactID.Location = new System.Drawing.Point(102, 31);
            this.contactID.Name = "contactID";
            this.contactID.Size = new System.Drawing.Size(31, 17);
            this.contactID.TabIndex = 26;
            this.contactID.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contact ID: ";
            // 
            // contactEmail
            // 
            this.contactEmail.AutoSize = true;
            this.contactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.contactEmail.Location = new System.Drawing.Point(412, 31);
            this.contactEmail.Name = "contactEmail";
            this.contactEmail.Size = new System.Drawing.Size(31, 17);
            this.contactEmail.TabIndex = 13;
            this.contactEmail.Text = "N/A";
            // 
            // contactLandline
            // 
            this.contactLandline.AutoSize = true;
            this.contactLandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.contactLandline.Location = new System.Drawing.Point(89, 115);
            this.contactLandline.Name = "contactLandline";
            this.contactLandline.Size = new System.Drawing.Size(31, 17);
            this.contactLandline.TabIndex = 12;
            this.contactLandline.Text = "N/A";
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.contactNumber.Location = new System.Drawing.Point(98, 88);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(31, 17);
            this.contactNumber.TabIndex = 11;
            this.contactNumber.Text = "N/A";
            // 
            // contactName
            // 
            this.contactName.AutoSize = true;
            this.contactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.contactName.Location = new System.Drawing.Point(72, 61);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(31, 17);
            this.contactName.TabIndex = 10;
            this.contactName.Text = "N/A";
            // 
            // citizenshipGrpBx
            // 
            this.citizenshipGrpBx.Controls.Add(this.CZPIssueDate);
            this.citizenshipGrpBx.Controls.Add(this.CZPIssueDistrict);
            this.citizenshipGrpBx.Controls.Add(this.CZPNumber);
            this.citizenshipGrpBx.Controls.Add(this.label4);
            this.citizenshipGrpBx.Controls.Add(this.CZPIssueDatelbl);
            this.citizenshipGrpBx.Controls.Add(this.CZPIssueDistrictlbl);
            this.citizenshipGrpBx.Location = new System.Drawing.Point(6, 135);
            this.citizenshipGrpBx.Name = "citizenshipGrpBx";
            this.citizenshipGrpBx.Size = new System.Drawing.Size(333, 89);
            this.citizenshipGrpBx.TabIndex = 8;
            this.citizenshipGrpBx.TabStop = false;
            // 
            // CZPIssueDate
            // 
            this.CZPIssueDate.AutoSize = true;
            this.CZPIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CZPIssueDate.Location = new System.Drawing.Point(103, 64);
            this.CZPIssueDate.Name = "CZPIssueDate";
            this.CZPIssueDate.Size = new System.Drawing.Size(31, 17);
            this.CZPIssueDate.TabIndex = 14;
            this.CZPIssueDate.Text = "N/A";
            // 
            // CZPIssueDistrict
            // 
            this.CZPIssueDistrict.AutoSize = true;
            this.CZPIssueDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CZPIssueDistrict.Location = new System.Drawing.Point(121, 38);
            this.CZPIssueDistrict.Name = "CZPIssueDistrict";
            this.CZPIssueDistrict.Size = new System.Drawing.Size(31, 17);
            this.CZPIssueDistrict.TabIndex = 14;
            this.CZPIssueDistrict.Text = "N/A";
            // 
            // CZPNumber
            // 
            this.CZPNumber.AutoSize = true;
            this.CZPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CZPNumber.Location = new System.Drawing.Point(128, 12);
            this.CZPNumber.Name = "CZPNumber";
            this.CZPNumber.Size = new System.Drawing.Size(31, 17);
            this.CZPNumber.TabIndex = 14;
            this.CZPNumber.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Citizenship No:";
            // 
            // CZPIssueDatelbl
            // 
            this.CZPIssueDatelbl.AutoSize = true;
            this.CZPIssueDatelbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CZPIssueDatelbl.Location = new System.Drawing.Point(6, 63);
            this.CZPIssueDatelbl.Name = "CZPIssueDatelbl";
            this.CZPIssueDatelbl.Size = new System.Drawing.Size(91, 18);
            this.CZPIssueDatelbl.TabIndex = 7;
            this.CZPIssueDatelbl.Text = "Issue Date: ";
            // 
            // CZPIssueDistrictlbl
            // 
            this.CZPIssueDistrictlbl.AutoSize = true;
            this.CZPIssueDistrictlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CZPIssueDistrictlbl.Location = new System.Drawing.Point(6, 37);
            this.CZPIssueDistrictlbl.Name = "CZPIssueDistrictlbl";
            this.CZPIssueDistrictlbl.Size = new System.Drawing.Size(109, 18);
            this.CZPIssueDistrictlbl.TabIndex = 6;
            this.CZPIssueDistrictlbl.Text = "Issue District: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(352, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Landline: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone No: ";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.nameLbl.Location = new System.Drawing.Point(6, 60);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(60, 18);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name:  ";
            // 
            // contactsGridVew
            // 
            this.contactsGridVew.AllowUserToAddRows = false;
            this.contactsGridVew.AllowUserToDeleteRows = false;
            this.contactsGridVew.AllowUserToResizeColumns = false;
            this.contactsGridVew.AllowUserToResizeRows = false;
            this.contactsGridVew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsGridVew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGridVew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactsGridVew.Location = new System.Drawing.Point(7, 243);
            this.contactsGridVew.MultiSelect = false;
            this.contactsGridVew.Name = "contactsGridVew";
            this.contactsGridVew.ReadOnly = true;
            this.contactsGridVew.RowHeadersVisible = false;
            this.contactsGridVew.RowHeadersWidth = 51;
            this.contactsGridVew.RowTemplate.Height = 24;
            this.contactsGridVew.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contactsGridVew.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactsGridVew.Size = new System.Drawing.Size(1091, 371);
            this.contactsGridVew.TabIndex = 1;
            this.contactsGridVew.SelectionChanged += new System.EventHandler(this.contactsGridVew_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 649);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.displayGrpTbx);
            this.tabPage1.Controls.Add(this.businessGridview);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1103, 620);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Business";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // displayGrpTbx
            // 
            this.displayGrpTbx.Controls.Add(this.businessType);
            this.displayGrpTbx.Controls.Add(this.typeLbl);
            this.displayGrpTbx.Controls.Add(this.businessDeleteBtn);
            this.displayGrpTbx.Controls.Add(this.businessEditBtn);
            this.displayGrpTbx.Controls.Add(this.businessNumber);
            this.displayGrpTbx.Controls.Add(this.label7);
            this.displayGrpTbx.Controls.Add(this.addBusinessBtn);
            this.displayGrpTbx.Controls.Add(this.businessEmail);
            this.displayGrpTbx.Controls.Add(this.BussLandlineNumber);
            this.displayGrpTbx.Controls.Add(this.bussMobileNumber);
            this.displayGrpTbx.Controls.Add(this.PANNumber);
            this.displayGrpTbx.Controls.Add(this.companyName);
            this.displayGrpTbx.Controls.Add(this.emailLbl);
            this.displayGrpTbx.Controls.Add(this.landlineLbl);
            this.displayGrpTbx.Controls.Add(this.mobileLbl);
            this.displayGrpTbx.Controls.Add(this.PanTbx);
            this.displayGrpTbx.Controls.Add(this.clientNameLbl);
            this.displayGrpTbx.Location = new System.Drawing.Point(6, 6);
            this.displayGrpTbx.Name = "displayGrpTbx";
            this.displayGrpTbx.Size = new System.Drawing.Size(1091, 231);
            this.displayGrpTbx.TabIndex = 1;
            this.displayGrpTbx.TabStop = false;
            this.displayGrpTbx.Text = "View";
            // 
            // businessType
            // 
            this.businessType.AutoSize = true;
            this.businessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.businessType.Location = new System.Drawing.Point(62, 195);
            this.businessType.Name = "businessType";
            this.businessType.Size = new System.Drawing.Size(31, 17);
            this.businessType.TabIndex = 24;
            this.businessType.Text = "N/A";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.typeLbl.Location = new System.Drawing.Point(6, 194);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(50, 18);
            this.typeLbl.TabIndex = 23;
            this.typeLbl.Text = "Type: ";
            // 
            // businessDeleteBtn
            // 
            this.businessDeleteBtn.Image = global::Rentmandu.Properties.Resources.minus;
            this.businessDeleteBtn.Location = new System.Drawing.Point(1029, 128);
            this.businessDeleteBtn.Name = "businessDeleteBtn";
            this.businessDeleteBtn.Size = new System.Drawing.Size(47, 47);
            this.businessDeleteBtn.TabIndex = 22;
            this.businessDeleteBtn.UseVisualStyleBackColor = true;
            this.businessDeleteBtn.Click += new System.EventHandler(this.businessDeleteBtn_Click);
            // 
            // businessEditBtn
            // 
            this.businessEditBtn.Image = global::Rentmandu.Properties.Resources.edit;
            this.businessEditBtn.Location = new System.Drawing.Point(1029, 80);
            this.businessEditBtn.Name = "businessEditBtn";
            this.businessEditBtn.Size = new System.Drawing.Size(47, 42);
            this.businessEditBtn.TabIndex = 21;
            this.businessEditBtn.UseVisualStyleBackColor = true;
            this.businessEditBtn.Click += new System.EventHandler(this.businessEditBtn_Click);
            // 
            // businessNumber
            // 
            this.businessNumber.AutoSize = true;
            this.businessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.businessNumber.Location = new System.Drawing.Point(91, 27);
            this.businessNumber.Name = "businessNumber";
            this.businessNumber.Size = new System.Drawing.Size(31, 17);
            this.businessNumber.TabIndex = 20;
            this.businessNumber.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Client ID: ";
            // 
            // addBusinessBtn
            // 
            this.addBusinessBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBusinessBtn.Image")));
            this.addBusinessBtn.Location = new System.Drawing.Point(1029, 27);
            this.addBusinessBtn.Name = "addBusinessBtn";
            this.addBusinessBtn.Size = new System.Drawing.Size(47, 47);
            this.addBusinessBtn.TabIndex = 18;
            this.addBusinessBtn.UseVisualStyleBackColor = true;
            this.addBusinessBtn.Click += new System.EventHandler(this.addBusinessBtn_Click);
            // 
            // businessEmail
            // 
            this.businessEmail.AutoSize = true;
            this.businessEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.businessEmail.Location = new System.Drawing.Point(67, 170);
            this.businessEmail.Name = "businessEmail";
            this.businessEmail.Size = new System.Drawing.Size(31, 17);
            this.businessEmail.TabIndex = 14;
            this.businessEmail.Text = "N/A";
            // 
            // BussLandlineNumber
            // 
            this.BussLandlineNumber.AutoSize = true;
            this.BussLandlineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BussLandlineNumber.Location = new System.Drawing.Point(104, 141);
            this.BussLandlineNumber.Name = "BussLandlineNumber";
            this.BussLandlineNumber.Size = new System.Drawing.Size(31, 17);
            this.BussLandlineNumber.TabIndex = 13;
            this.BussLandlineNumber.Text = "N/A";
            // 
            // bussMobileNumber
            // 
            this.bussMobileNumber.AutoSize = true;
            this.bussMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bussMobileNumber.Location = new System.Drawing.Point(100, 115);
            this.bussMobileNumber.Name = "bussMobileNumber";
            this.bussMobileNumber.Size = new System.Drawing.Size(31, 17);
            this.bussMobileNumber.TabIndex = 12;
            this.bussMobileNumber.Text = "N/A";
            // 
            // PANNumber
            // 
            this.PANNumber.AutoSize = true;
            this.PANNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PANNumber.Location = new System.Drawing.Point(76, 82);
            this.PANNumber.Name = "PANNumber";
            this.PANNumber.Size = new System.Drawing.Size(31, 17);
            this.PANNumber.TabIndex = 10;
            this.PANNumber.Text = "N/A";
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.companyName.Location = new System.Drawing.Point(142, 53);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(31, 17);
            this.companyName.TabIndex = 9;
            this.companyName.Text = "N/A";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.emailLbl.Location = new System.Drawing.Point(7, 169);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(54, 18);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "Email: ";
            // 
            // landlineLbl
            // 
            this.landlineLbl.AutoSize = true;
            this.landlineLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.landlineLbl.Location = new System.Drawing.Point(6, 141);
            this.landlineLbl.Name = "landlineLbl";
            this.landlineLbl.Size = new System.Drawing.Size(101, 18);
            this.landlineLbl.TabIndex = 5;
            this.landlineLbl.Text = "Landline No: ";
            // 
            // mobileLbl
            // 
            this.mobileLbl.AutoSize = true;
            this.mobileLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.mobileLbl.Location = new System.Drawing.Point(6, 114);
            this.mobileLbl.Name = "mobileLbl";
            this.mobileLbl.Size = new System.Drawing.Size(88, 18);
            this.mobileLbl.TabIndex = 4;
            this.mobileLbl.Text = "Mobile No: ";
            // 
            // PanTbx
            // 
            this.PanTbx.AutoSize = true;
            this.PanTbx.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.PanTbx.Location = new System.Drawing.Point(7, 81);
            this.PanTbx.Name = "PanTbx";
            this.PanTbx.Size = new System.Drawing.Size(69, 18);
            this.PanTbx.TabIndex = 1;
            this.PanTbx.Text = "PAN No: ";
            // 
            // clientNameLbl
            // 
            this.clientNameLbl.AutoSize = true;
            this.clientNameLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.clientNameLbl.Location = new System.Drawing.Point(7, 52);
            this.clientNameLbl.Name = "clientNameLbl";
            this.clientNameLbl.Size = new System.Drawing.Size(129, 18);
            this.clientNameLbl.TabIndex = 0;
            this.clientNameLbl.Text = "Company Name:  ";
            // 
            // businessGridview
            // 
            this.businessGridview.AllowUserToAddRows = false;
            this.businessGridview.AllowUserToResizeColumns = false;
            this.businessGridview.AllowUserToResizeRows = false;
            this.businessGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.businessGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessGridview.Location = new System.Drawing.Point(6, 243);
            this.businessGridview.MultiSelect = false;
            this.businessGridview.Name = "businessGridview";
            this.businessGridview.RowHeadersVisible = false;
            this.businessGridview.RowHeadersWidth = 51;
            this.businessGridview.RowTemplate.Height = 24;
            this.businessGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessGridview.Size = new System.Drawing.Size(1091, 371);
            this.businessGridview.TabIndex = 0;
            this.businessGridview.SelectionChanged += new System.EventHandler(this.businessGridview_SelectionChanged);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Contacts";
            this.Size = new System.Drawing.Size(1111, 649);
            this.tabPage2.ResumeLayout(false);
            this.viewGroupBx.ResumeLayout(false);
            this.viewGroupBx.PerformLayout();
            this.citizenshipGrpBx.ResumeLayout(false);
            this.citizenshipGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridVew)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.displayGrpTbx.ResumeLayout(false);
            this.displayGrpTbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox displayGrpTbx;
        private System.Windows.Forms.Label businessType;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Button businessDeleteBtn;
        private System.Windows.Forms.Button businessEditBtn;
        private System.Windows.Forms.Label businessNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBusinessBtn;
        private System.Windows.Forms.Label businessEmail;
        private System.Windows.Forms.Label BussLandlineNumber;
        private System.Windows.Forms.Label bussMobileNumber;
        private System.Windows.Forms.Label PANNumber;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label landlineLbl;
        private System.Windows.Forms.Label mobileLbl;
        private System.Windows.Forms.Label PanTbx;
        private System.Windows.Forms.Label clientNameLbl;
        private System.Windows.Forms.DataGridView businessGridview;
        private System.Windows.Forms.GroupBox viewGroupBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.GroupBox citizenshipGrpBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CZPIssueDatelbl;
        private System.Windows.Forms.Label CZPIssueDistrictlbl;
        private System.Windows.Forms.Label contactEmail;
        private System.Windows.Forms.Label contactLandline;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.Label contactName;
        private System.Windows.Forms.Label CZPIssueDate;
        private System.Windows.Forms.Label CZPIssueDistrict;
        private System.Windows.Forms.Label CZPNumber;
        private System.Windows.Forms.DataGridView contactsGridVew;
        private System.Windows.Forms.Label contactID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addContactBtn;
        private System.Windows.Forms.Button deleteContactsBtn;
        private System.Windows.Forms.Button contactsEditBtn;
    }
}
