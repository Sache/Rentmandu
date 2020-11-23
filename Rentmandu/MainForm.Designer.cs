namespace Rentmandu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logsBtn = new System.Windows.Forms.Button();
            this.contactsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Location = new System.Drawing.Point(100, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1111, 649);
            this.mainPanel.TabIndex = 0;
            // 
            // logsBtn
            // 
            this.logsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logsBtn.Image = global::Rentmandu.Properties.Resources.log;
            this.logsBtn.Location = new System.Drawing.Point(12, 105);
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.Size = new System.Drawing.Size(72, 72);
            this.logsBtn.TabIndex = 1;
            this.logsBtn.UseVisualStyleBackColor = true;
            this.logsBtn.Click += new System.EventHandler(this.logsBtn_Click);
            // 
            // contactsBtn
            // 
            this.contactsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactsBtn.Image = global::Rentmandu.Properties.Resources.contacts;
            this.contactsBtn.Location = new System.Drawing.Point(12, 27);
            this.contactsBtn.Name = "contactsBtn";
            this.contactsBtn.Size = new System.Drawing.Size(72, 72);
            this.contactsBtn.TabIndex = 0;
            this.contactsBtn.UseVisualStyleBackColor = true;
            this.contactsBtn.Click += new System.EventHandler(this.contactsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1223, 673);
            this.Controls.Add(this.logsBtn);
            this.Controls.Add(this.contactsBtn);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Rentmandu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button contactsBtn;
        private System.Windows.Forms.Button logsBtn;
    }
}