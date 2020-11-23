namespace Rentmandu.UserControls
{
    partial class Property
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property));
            this.addContactBtn = new System.Windows.Forms.Button();
            this.contactsEditBtn = new System.Windows.Forms.Button();
            this.deleteContactsBtn = new System.Windows.Forms.Button();
            this.propertyGrpBx = new System.Windows.Forms.GroupBox();
            this.propertyGridView = new System.Windows.Forms.DataGridView();
            this.propertyGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addContactBtn
            // 
            this.addContactBtn.Image = ((System.Drawing.Image)(resources.GetObject("addContactBtn.Image")));
            this.addContactBtn.Location = new System.Drawing.Point(476, 21);
            this.addContactBtn.Name = "addContactBtn";
            this.addContactBtn.Size = new System.Drawing.Size(46, 47);
            this.addContactBtn.TabIndex = 30;
            this.addContactBtn.UseVisualStyleBackColor = true;
            // 
            // contactsEditBtn
            // 
            this.contactsEditBtn.Image = global::Rentmandu.Properties.Resources.edit;
            this.contactsEditBtn.Location = new System.Drawing.Point(528, 21);
            this.contactsEditBtn.Name = "contactsEditBtn";
            this.contactsEditBtn.Size = new System.Drawing.Size(46, 47);
            this.contactsEditBtn.TabIndex = 31;
            this.contactsEditBtn.UseVisualStyleBackColor = true;
            // 
            // deleteContactsBtn
            // 
            this.deleteContactsBtn.Image = global::Rentmandu.Properties.Resources.minus;
            this.deleteContactsBtn.Location = new System.Drawing.Point(580, 21);
            this.deleteContactsBtn.Name = "deleteContactsBtn";
            this.deleteContactsBtn.Size = new System.Drawing.Size(46, 47);
            this.deleteContactsBtn.TabIndex = 32;
            this.deleteContactsBtn.UseVisualStyleBackColor = true;
            // 
            // propertyGrpBx
            // 
            this.propertyGrpBx.Controls.Add(this.propertyGridView);
            this.propertyGrpBx.Controls.Add(this.deleteContactsBtn);
            this.propertyGrpBx.Controls.Add(this.contactsEditBtn);
            this.propertyGrpBx.Controls.Add(this.addContactBtn);
            this.propertyGrpBx.Location = new System.Drawing.Point(3, 3);
            this.propertyGrpBx.Name = "propertyGrpBx";
            this.propertyGrpBx.Size = new System.Drawing.Size(1105, 643);
            this.propertyGrpBx.TabIndex = 33;
            this.propertyGrpBx.TabStop = false;
            this.propertyGrpBx.Text = "Property";
            // 
            // propertyGridView
            // 
            this.propertyGridView.AllowUserToAddRows = false;
            this.propertyGridView.AllowUserToDeleteRows = false;
            this.propertyGridView.AllowUserToResizeColumns = false;
            this.propertyGridView.AllowUserToResizeRows = false;
            this.propertyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.propertyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.propertyGridView.Location = new System.Drawing.Point(6, 74);
            this.propertyGridView.MultiSelect = false;
            this.propertyGridView.Name = "propertyGridView";
            this.propertyGridView.ReadOnly = true;
            this.propertyGridView.RowHeadersVisible = false;
            this.propertyGridView.RowHeadersWidth = 51;
            this.propertyGridView.RowTemplate.Height = 24;
            this.propertyGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.propertyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.propertyGridView.Size = new System.Drawing.Size(1093, 563);
            this.propertyGridView.TabIndex = 5;
            // 
            // Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propertyGrpBx);
            this.Name = "Property";
            this.Size = new System.Drawing.Size(1111, 649);
            this.propertyGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addContactBtn;
        private System.Windows.Forms.Button contactsEditBtn;
        private System.Windows.Forms.Button deleteContactsBtn;
        private System.Windows.Forms.GroupBox propertyGrpBx;
        private System.Windows.Forms.DataGridView propertyGridView;
    }
}
