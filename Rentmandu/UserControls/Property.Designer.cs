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
            this.addPropertyBtn = new System.Windows.Forms.Button();
            this.editPropertyBtn = new System.Windows.Forms.Button();
            this.deletePropertyBtn = new System.Windows.Forms.Button();
            this.propertyGrpBx = new System.Windows.Forms.GroupBox();
            this.propertyGridView = new System.Windows.Forms.DataGridView();
            this.propertyGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPropertyBtn
            // 
            this.addPropertyBtn.Image = ((System.Drawing.Image)(resources.GetObject("addPropertyBtn.Image")));
            this.addPropertyBtn.Location = new System.Drawing.Point(476, 21);
            this.addPropertyBtn.Name = "addPropertyBtn";
            this.addPropertyBtn.Size = new System.Drawing.Size(46, 47);
            this.addPropertyBtn.TabIndex = 30;
            this.addPropertyBtn.UseVisualStyleBackColor = true;
            this.addPropertyBtn.Click += new System.EventHandler(this.addPropertyBtn_Click);
            // 
            // editPropertyBtn
            // 
            this.editPropertyBtn.Image = global::Rentmandu.Properties.Resources.edit;
            this.editPropertyBtn.Location = new System.Drawing.Point(528, 21);
            this.editPropertyBtn.Name = "editPropertyBtn";
            this.editPropertyBtn.Size = new System.Drawing.Size(46, 47);
            this.editPropertyBtn.TabIndex = 31;
            this.editPropertyBtn.UseVisualStyleBackColor = true;
            this.editPropertyBtn.Click += new System.EventHandler(this.editPropertyBtn_Click);
            // 
            // deletePropertyBtn
            // 
            this.deletePropertyBtn.Image = global::Rentmandu.Properties.Resources.minus;
            this.deletePropertyBtn.Location = new System.Drawing.Point(580, 21);
            this.deletePropertyBtn.Name = "deletePropertyBtn";
            this.deletePropertyBtn.Size = new System.Drawing.Size(46, 47);
            this.deletePropertyBtn.TabIndex = 32;
            this.deletePropertyBtn.UseVisualStyleBackColor = true;
            this.deletePropertyBtn.Click += new System.EventHandler(this.deletePropertyBtn_Click);
            // 
            // propertyGrpBx
            // 
            this.propertyGrpBx.Controls.Add(this.propertyGridView);
            this.propertyGrpBx.Controls.Add(this.deletePropertyBtn);
            this.propertyGrpBx.Controls.Add(this.editPropertyBtn);
            this.propertyGrpBx.Controls.Add(this.addPropertyBtn);
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
            this.propertyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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

        private System.Windows.Forms.Button addPropertyBtn;
        private System.Windows.Forms.Button editPropertyBtn;
        private System.Windows.Forms.Button deletePropertyBtn;
        private System.Windows.Forms.GroupBox propertyGrpBx;
        private System.Windows.Forms.DataGridView propertyGridView;
    }
}
