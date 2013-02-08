namespace MagicManager.Forms
{
    partial class WantNewDBForm
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
            this.Label = new System.Windows.Forms.TextBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Label.Location = new System.Drawing.Point(12, 32);
            this.Label.Multiline = true;
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            this.Label.Size = new System.Drawing.Size(467, 43);
            this.Label.TabIndex = 0;
            this.Label.TabStop = false;
            this.Label.Text = "There is currently no database selected containing a list of your owned cards. \r\n" +
    "Would you like to create a new one?";
            this.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YesBtn
            // 
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.YesBtn.Location = new System.Drawing.Point(104, 122);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(75, 23);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoBtn.Location = new System.Drawing.Point(302, 122);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(75, 23);
            this.NoBtn.TabIndex = 2;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // WantNewDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(491, 185);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WantNewDBForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Label;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
    }
}