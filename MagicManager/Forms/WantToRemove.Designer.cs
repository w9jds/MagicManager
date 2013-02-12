namespace MagicManager
{
    partial class WantToRemove
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
            this.Ask = new System.Windows.Forms.TextBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.RemoveCard = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Ask
            // 
            this.Ask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ask.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Ask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ask.ForeColor = System.Drawing.SystemColors.Window;
            this.Ask.Location = new System.Drawing.Point(12, 36);
            this.Ask.Name = "Ask";
            this.Ask.ReadOnly = true;
            this.Ask.Size = new System.Drawing.Size(532, 16);
            this.Ask.TabIndex = 0;
            this.Ask.TabStop = false;
            this.Ask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YesBtn
            // 
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YesBtn.Location = new System.Drawing.Point(119, 81);
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
            this.NoBtn.Location = new System.Drawing.Point(325, 81);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(75, 23);
            this.NoBtn.TabIndex = 2;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // RemoveCard
            // 
            this.RemoveCard.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RemoveCard_DoWork);
            // 
            // WantToRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(556, 116);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.Ask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WantToRemove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ask;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.ComponentModel.BackgroundWorker RemoveCard;
    }
}