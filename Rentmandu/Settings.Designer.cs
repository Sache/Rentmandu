namespace Rentmandu
{
    partial class Settings
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
            this.companyTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbNameTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hostTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyTbx
            // 
            this.companyTbx.Location = new System.Drawing.Point(224, 187);
            this.companyTbx.Name = "companyTbx";
            this.companyTbx.Size = new System.Drawing.Size(162, 22);
            this.companyTbx.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Company Name:";
            // 
            // dbNameTbx
            // 
            this.dbNameTbx.Location = new System.Drawing.Point(224, 151);
            this.dbNameTbx.Name = "dbNameTbx";
            this.dbNameTbx.Size = new System.Drawing.Size(162, 22);
            this.dbNameTbx.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Database Name:";
            // 
            // hostTbx
            // 
            this.hostTbx.Location = new System.Drawing.Point(224, 46);
            this.hostTbx.Name = "hostTbx";
            this.hostTbx.Size = new System.Drawing.Size(162, 22);
            this.hostTbx.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Connection Host:";
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(224, 117);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(162, 22);
            this.passwordTbx.TabIndex = 42;
            this.passwordTbx.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Database Password:";
            // 
            // usernameTbx
            // 
            this.usernameTbx.Location = new System.Drawing.Point(224, 81);
            this.usernameTbx.Name = "usernameTbx";
            this.usernameTbx.Size = new System.Drawing.Size(162, 22);
            this.usernameTbx.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Database Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.companyTbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dbNameTbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hostTbx);
            this.groupBox1.Controls.Add(this.passwordTbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.usernameTbx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 274);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(268, 227);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 29);
            this.saveBtn.TabIndex = 50;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 298);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox companyTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dbNameTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hostTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
    }
}