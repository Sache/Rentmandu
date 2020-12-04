namespace Rentmandu.UserControls
{
    partial class Email
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
            this.emailGrpBox = new System.Windows.Forms.GroupBox();
            this.emailSettingsGrpBx = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBody = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.emailTo = new System.Windows.Forms.TextBox();
            this.emailSubject = new System.Windows.Forms.TextBox();
            this.emailTemplatesGrpBx = new System.Windows.Forms.GroupBox();
            this.templatesListBx = new System.Windows.Forms.ListBox();
            this.useTemplate = new System.Windows.Forms.Button();
            this.addtemplate = new System.Windows.Forms.Button();
            this.deleteTemplates = new System.Windows.Forms.Button();
            this.EmailPasswdTbx = new System.Windows.Forms.TextBox();
            this.fromEmailTbx = new System.Windows.Forms.TextBox();
            this.emailPortTbx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.smtpServerTbx = new System.Windows.Forms.TextBox();
            this.emailGrpBox.SuspendLayout();
            this.emailSettingsGrpBx.SuspendLayout();
            this.emailTemplatesGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailPortTbx)).BeginInit();
            this.SuspendLayout();
            // 
            // emailGrpBox
            // 
            this.emailGrpBox.Controls.Add(this.emailTemplatesGrpBx);
            this.emailGrpBox.Controls.Add(this.emailSubject);
            this.emailGrpBox.Controls.Add(this.emailTo);
            this.emailGrpBox.Controls.Add(this.sendBtn);
            this.emailGrpBox.Controls.Add(this.emailBody);
            this.emailGrpBox.Controls.Add(this.label2);
            this.emailGrpBox.Controls.Add(this.label1);
            this.emailGrpBox.Controls.Add(this.emailSettingsGrpBx);
            this.emailGrpBox.Location = new System.Drawing.Point(3, 3);
            this.emailGrpBox.Name = "emailGrpBox";
            this.emailGrpBox.Size = new System.Drawing.Size(1099, 637);
            this.emailGrpBox.TabIndex = 1;
            this.emailGrpBox.TabStop = false;
            this.emailGrpBox.Text = "Email";
            // 
            // emailSettingsGrpBx
            // 
            this.emailSettingsGrpBx.Controls.Add(this.smtpServerTbx);
            this.emailSettingsGrpBx.Controls.Add(this.label6);
            this.emailSettingsGrpBx.Controls.Add(this.label5);
            this.emailSettingsGrpBx.Controls.Add(this.label4);
            this.emailSettingsGrpBx.Controls.Add(this.label3);
            this.emailSettingsGrpBx.Controls.Add(this.emailPortTbx);
            this.emailSettingsGrpBx.Controls.Add(this.fromEmailTbx);
            this.emailSettingsGrpBx.Controls.Add(this.EmailPasswdTbx);
            this.emailSettingsGrpBx.Location = new System.Drawing.Point(714, 21);
            this.emailSettingsGrpBx.Name = "emailSettingsGrpBx";
            this.emailSettingsGrpBx.Size = new System.Drawing.Size(354, 157);
            this.emailSettingsGrpBx.TabIndex = 0;
            this.emailSettingsGrpBx.TabStop = false;
            this.emailSettingsGrpBx.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "To: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject: ";
            // 
            // emailBody
            // 
            this.emailBody.Location = new System.Drawing.Point(21, 110);
            this.emailBody.Name = "emailBody";
            this.emailBody.Size = new System.Drawing.Size(674, 431);
            this.emailBody.TabIndex = 3;
            this.emailBody.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(21, 557);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(87, 35);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // emailTo
            // 
            this.emailTo.Location = new System.Drawing.Point(87, 43);
            this.emailTo.Name = "emailTo";
            this.emailTo.Size = new System.Drawing.Size(608, 22);
            this.emailTo.TabIndex = 6;
            // 
            // emailSubject
            // 
            this.emailSubject.Location = new System.Drawing.Point(87, 78);
            this.emailSubject.Name = "emailSubject";
            this.emailSubject.Size = new System.Drawing.Size(608, 22);
            this.emailSubject.TabIndex = 7;
            // 
            // emailTemplatesGrpBx
            // 
            this.emailTemplatesGrpBx.Controls.Add(this.deleteTemplates);
            this.emailTemplatesGrpBx.Controls.Add(this.addtemplate);
            this.emailTemplatesGrpBx.Controls.Add(this.useTemplate);
            this.emailTemplatesGrpBx.Controls.Add(this.templatesListBx);
            this.emailTemplatesGrpBx.Location = new System.Drawing.Point(714, 184);
            this.emailTemplatesGrpBx.Name = "emailTemplatesGrpBx";
            this.emailTemplatesGrpBx.Size = new System.Drawing.Size(354, 447);
            this.emailTemplatesGrpBx.TabIndex = 8;
            this.emailTemplatesGrpBx.TabStop = false;
            this.emailTemplatesGrpBx.Text = "Templates";
            // 
            // templatesListBx
            // 
            this.templatesListBx.FormattingEnabled = true;
            this.templatesListBx.ItemHeight = 16;
            this.templatesListBx.Location = new System.Drawing.Point(7, 22);
            this.templatesListBx.Name = "templatesListBx";
            this.templatesListBx.Size = new System.Drawing.Size(341, 372);
            this.templatesListBx.TabIndex = 0;
            // 
            // useTemplate
            // 
            this.useTemplate.Location = new System.Drawing.Point(17, 410);
            this.useTemplate.Name = "useTemplate";
            this.useTemplate.Size = new System.Drawing.Size(75, 31);
            this.useTemplate.TabIndex = 1;
            this.useTemplate.Text = "Use";
            this.useTemplate.UseVisualStyleBackColor = true;
            // 
            // addtemplate
            // 
            this.addtemplate.Location = new System.Drawing.Point(141, 410);
            this.addtemplate.Name = "addtemplate";
            this.addtemplate.Size = new System.Drawing.Size(75, 31);
            this.addtemplate.TabIndex = 2;
            this.addtemplate.Text = "Add";
            this.addtemplate.UseVisualStyleBackColor = true;
            // 
            // deleteTemplates
            // 
            this.deleteTemplates.Location = new System.Drawing.Point(259, 410);
            this.deleteTemplates.Name = "deleteTemplates";
            this.deleteTemplates.Size = new System.Drawing.Size(75, 31);
            this.deleteTemplates.TabIndex = 3;
            this.deleteTemplates.Text = "Delete";
            this.deleteTemplates.UseVisualStyleBackColor = true;
            // 
            // EmailPasswdTbx
            // 
            this.EmailPasswdTbx.Location = new System.Drawing.Point(120, 62);
            this.EmailPasswdTbx.Name = "EmailPasswdTbx";
            this.EmailPasswdTbx.Size = new System.Drawing.Size(214, 22);
            this.EmailPasswdTbx.TabIndex = 0;
            this.EmailPasswdTbx.UseSystemPasswordChar = true;
            this.EmailPasswdTbx.TextChanged += new System.EventHandler(this.EmailPasswdTbx_TextChanged);
            // 
            // fromEmailTbx
            // 
            this.fromEmailTbx.Location = new System.Drawing.Point(120, 26);
            this.fromEmailTbx.Name = "fromEmailTbx";
            this.fromEmailTbx.Size = new System.Drawing.Size(214, 22);
            this.fromEmailTbx.TabIndex = 0;
            this.fromEmailTbx.TextChanged += new System.EventHandler(this.fromEmailTbx_TextChanged);
            // 
            // emailPortTbx
            // 
            this.emailPortTbx.Location = new System.Drawing.Point(120, 126);
            this.emailPortTbx.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.emailPortTbx.Name = "emailPortTbx";
            this.emailPortTbx.Size = new System.Drawing.Size(75, 22);
            this.emailPortTbx.TabIndex = 1;
            this.emailPortTbx.ValueChanged += new System.EventHandler(this.emailPortTbx_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "From Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "SMTP Server: ";
            // 
            // smtpServerTbx
            // 
            this.smtpServerTbx.Location = new System.Drawing.Point(120, 96);
            this.smtpServerTbx.Name = "smtpServerTbx";
            this.smtpServerTbx.Size = new System.Drawing.Size(214, 22);
            this.smtpServerTbx.TabIndex = 6;
            this.smtpServerTbx.TextChanged += new System.EventHandler(this.smtpServerTbx_TextChanged);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emailGrpBox);
            this.Name = "Email";
            this.Size = new System.Drawing.Size(1105, 643);
            this.emailGrpBox.ResumeLayout(false);
            this.emailGrpBox.PerformLayout();
            this.emailSettingsGrpBx.ResumeLayout(false);
            this.emailSettingsGrpBx.PerformLayout();
            this.emailTemplatesGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emailPortTbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox emailGrpBox;
        private System.Windows.Forms.GroupBox emailSettingsGrpBx;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.RichTextBox emailBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailSubject;
        private System.Windows.Forms.TextBox emailTo;
        private System.Windows.Forms.GroupBox emailTemplatesGrpBx;
        private System.Windows.Forms.ListBox templatesListBx;
        private System.Windows.Forms.Button addtemplate;
        private System.Windows.Forms.Button useTemplate;
        private System.Windows.Forms.Button deleteTemplates;
        private System.Windows.Forms.TextBox fromEmailTbx;
        private System.Windows.Forms.TextBox EmailPasswdTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown emailPortTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox smtpServerTbx;
        private System.Windows.Forms.Label label6;
    }
}
