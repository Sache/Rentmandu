namespace Rentmandu.UserControls
{
    partial class LogsInfo
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
            this.logsTbx = new System.Windows.Forms.RichTextBox();
            this.logsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logsTbx
            // 
            this.logsTbx.Location = new System.Drawing.Point(23, 45);
            this.logsTbx.Name = "logsTbx";
            this.logsTbx.Size = new System.Drawing.Size(1070, 585);
            this.logsTbx.TabIndex = 0;
            this.logsTbx.Text = "";
            // 
            // logsLbl
            // 
            this.logsLbl.AutoSize = true;
            this.logsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.logsLbl.Location = new System.Drawing.Point(510, 24);
            this.logsLbl.Name = "logsLbl";
            this.logsLbl.Size = new System.Drawing.Size(45, 18);
            this.logsLbl.TabIndex = 1;
            this.logsLbl.Text = "Logs";
            // 
            // LogsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logsLbl);
            this.Controls.Add(this.logsTbx);
            this.Name = "LogsInfo";
            this.Size = new System.Drawing.Size(1111, 649);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logsTbx;
        private System.Windows.Forms.Label logsLbl;
    }
}
