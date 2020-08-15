namespace Rentmandu.UserForms
{
    partial class BusinessActions
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
            this.landlineTbx = new System.Windows.Forms.TextBox();
            this.businessSaveBtn = new System.Windows.Forms.Button();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.mobileTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.contactActionsGrpBx = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bussTypeTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panNumberTbx = new System.Windows.Forms.TextBox();
            this.contactActionsGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // landlineTbx
            // 
            this.landlineTbx.Location = new System.Drawing.Point(162, 108);
            this.landlineTbx.Name = "landlineTbx";
            this.landlineTbx.Size = new System.Drawing.Size(225, 22);
            this.landlineTbx.TabIndex = 27;
            this.landlineTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // businessSaveBtn
            // 
            this.businessSaveBtn.Location = new System.Drawing.Point(162, 287);
            this.businessSaveBtn.Name = "businessSaveBtn";
            this.businessSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.businessSaveBtn.TabIndex = 15;
            this.businessSaveBtn.Text = "Save";
            this.businessSaveBtn.UseVisualStyleBackColor = true;
            this.businessSaveBtn.Click += new System.EventHandler(this.businessSaveBtn_Click);
            // 
            // emailTbx
            // 
            this.emailTbx.Location = new System.Drawing.Point(162, 200);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(225, 22);
            this.emailTbx.TabIndex = 29;
            // 
            // mobileTbx
            // 
            this.mobileTbx.Location = new System.Drawing.Point(162, 154);
            this.mobileTbx.Name = "mobileTbx";
            this.mobileTbx.Size = new System.Drawing.Size(225, 22);
            this.mobileTbx.TabIndex = 28;
            this.mobileTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "PHONE NUMBER: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "MOBILE: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "EMAIL: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "BUSINESS NAME: ";
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(162, 28);
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(225, 22);
            this.nameTbx.TabIndex = 19;
            // 
            // contactActionsGrpBx
            // 
            this.contactActionsGrpBx.Controls.Add(this.label4);
            this.contactActionsGrpBx.Controls.Add(this.bussTypeTbx);
            this.contactActionsGrpBx.Controls.Add(this.label3);
            this.contactActionsGrpBx.Controls.Add(this.panNumberTbx);
            this.contactActionsGrpBx.Controls.Add(this.businessSaveBtn);
            this.contactActionsGrpBx.Controls.Add(this.landlineTbx);
            this.contactActionsGrpBx.Controls.Add(this.nameTbx);
            this.contactActionsGrpBx.Controls.Add(this.label1);
            this.contactActionsGrpBx.Controls.Add(this.label2);
            this.contactActionsGrpBx.Controls.Add(this.emailTbx);
            this.contactActionsGrpBx.Controls.Add(this.mobileTbx);
            this.contactActionsGrpBx.Controls.Add(this.label7);
            this.contactActionsGrpBx.Controls.Add(this.label6);
            this.contactActionsGrpBx.Location = new System.Drawing.Point(12, 12);
            this.contactActionsGrpBx.Name = "contactActionsGrpBx";
            this.contactActionsGrpBx.Size = new System.Drawing.Size(429, 345);
            this.contactActionsGrpBx.TabIndex = 34;
            this.contactActionsGrpBx.TabStop = false;
            this.contactActionsGrpBx.Text = "Business Form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "TYPE: ";
            // 
            // bussTypeTbx
            // 
            this.bussTypeTbx.Location = new System.Drawing.Point(162, 70);
            this.bussTypeTbx.Name = "bussTypeTbx";
            this.bussTypeTbx.Size = new System.Drawing.Size(225, 22);
            this.bussTypeTbx.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "PAN NUMBER: ";
            // 
            // panNumberTbx
            // 
            this.panNumberTbx.Location = new System.Drawing.Point(162, 245);
            this.panNumberTbx.Name = "panNumberTbx";
            this.panNumberTbx.Size = new System.Drawing.Size(225, 22);
            this.panNumberTbx.TabIndex = 30;
            this.panNumberTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // BusinessActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 369);
            this.Controls.Add(this.contactActionsGrpBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessActions";
            this.Text = "BusinessActions";
            this.contactActionsGrpBx.ResumeLayout(false);
            this.contactActionsGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox landlineTbx;
        private System.Windows.Forms.Button businessSaveBtn;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.TextBox mobileTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.GroupBox contactActionsGrpBx;
        private System.Windows.Forms.TextBox panNumberTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bussTypeTbx;
    }
}