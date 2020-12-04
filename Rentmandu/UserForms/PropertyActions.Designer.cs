namespace Rentmandu.UserForms
{
    partial class PropertyActions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pNameTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pTypeTbx = new System.Windows.Forms.ComboBox();
            this.pLocationTbx = new System.Windows.Forms.TextBox();
            this.pNotesTbx = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pLandlordTbx = new System.Windows.Forms.ComboBox();
            this.pSaveBtn = new System.Windows.Forms.Button();
            this.propertyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNameTbx
            // 
            this.pNameTbx.Location = new System.Drawing.Point(179, 27);
            this.pNameTbx.Name = "pNameTbx";
            this.pNameTbx.Size = new System.Drawing.Size(157, 22);
            this.pNameTbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Property Name:";
            // 
            // propertyGroupBox
            // 
            this.propertyGroupBox.Controls.Add(this.pSaveBtn);
            this.propertyGroupBox.Controls.Add(this.pLandlordTbx);
            this.propertyGroupBox.Controls.Add(this.label5);
            this.propertyGroupBox.Controls.Add(this.label4);
            this.propertyGroupBox.Controls.Add(this.label3);
            this.propertyGroupBox.Controls.Add(this.pNotesTbx);
            this.propertyGroupBox.Controls.Add(this.pLocationTbx);
            this.propertyGroupBox.Controls.Add(this.label2);
            this.propertyGroupBox.Controls.Add(this.pTypeTbx);
            this.propertyGroupBox.Controls.Add(this.pNameTbx);
            this.propertyGroupBox.Controls.Add(this.label1);
            this.propertyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.propertyGroupBox.Name = "propertyGroupBox";
            this.propertyGroupBox.Size = new System.Drawing.Size(490, 424);
            this.propertyGroupBox.TabIndex = 2;
            this.propertyGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // pTypeTbx
            // 
            this.pTypeTbx.FormattingEnabled = true;
            this.pTypeTbx.Items.AddRange(new object[] {
            "Land",
            "House",
            "Flat",
            "Room",
            "Shutter",
            "Office",
            "Parking",
            "Garage"});
            this.pTypeTbx.Location = new System.Drawing.Point(179, 83);
            this.pTypeTbx.Name = "pTypeTbx";
            this.pTypeTbx.Size = new System.Drawing.Size(157, 24);
            this.pTypeTbx.TabIndex = 2;
            // 
            // pLocationTbx
            // 
            this.pLocationTbx.Location = new System.Drawing.Point(179, 137);
            this.pLocationTbx.Name = "pLocationTbx";
            this.pLocationTbx.Size = new System.Drawing.Size(157, 22);
            this.pLocationTbx.TabIndex = 4;
            // 
            // pNotesTbx
            // 
            this.pNotesTbx.Location = new System.Drawing.Point(179, 186);
            this.pNotesTbx.Name = "pNotesTbx";
            this.pNotesTbx.Size = new System.Drawing.Size(244, 125);
            this.pNotesTbx.TabIndex = 5;
            this.pNotesTbx.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Landlord:";
            // 
            // pLandlordTbx
            // 
            this.pLandlordTbx.FormattingEnabled = true;
            this.pLandlordTbx.Location = new System.Drawing.Point(179, 332);
            this.pLandlordTbx.Name = "pLandlordTbx";
            this.pLandlordTbx.Size = new System.Drawing.Size(157, 24);
            this.pLandlordTbx.TabIndex = 9;
            this.pLandlordTbx.Text = " ";
            // 
            // pSaveBtn
            // 
            this.pSaveBtn.Location = new System.Drawing.Point(222, 381);
            this.pSaveBtn.Name = "pSaveBtn";
            this.pSaveBtn.Size = new System.Drawing.Size(74, 37);
            this.pSaveBtn.TabIndex = 10;
            this.pSaveBtn.Text = "Save";
            this.pSaveBtn.UseVisualStyleBackColor = true;
            this.pSaveBtn.Click += new System.EventHandler(this.pSaveBtn_Click);
            // 
            // PropertyActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.propertyGroupBox);
            this.Name = "PropertyActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropertyActions";
            this.propertyGroupBox.ResumeLayout(false);
            this.propertyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox pNameTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox propertyGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pTypeTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox pNotesTbx;
        private System.Windows.Forms.TextBox pLocationTbx;
        private System.Windows.Forms.ComboBox pLandlordTbx;
        private System.Windows.Forms.Button pSaveBtn;
    }
}