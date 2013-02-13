namespace MagicManager
{
    partial class AddToDoubleFrm
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
            this.YouHaveDouble = new System.Windows.Forms.TextBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.UpdateOwnedBWG = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // YouHaveDouble
            // 
            this.YouHaveDouble.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YouHaveDouble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YouHaveDouble.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.YouHaveDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YouHaveDouble.ForeColor = System.Drawing.SystemColors.Window;
            this.YouHaveDouble.Location = new System.Drawing.Point(12, 31);
            this.YouHaveDouble.Multiline = true;
            this.YouHaveDouble.Name = "YouHaveDouble";
            this.YouHaveDouble.ReadOnly = true;
            this.YouHaveDouble.Size = new System.Drawing.Size(535, 79);
            this.YouHaveDouble.TabIndex = 0;
            this.YouHaveDouble.TabStop = false;
            this.YouHaveDouble.Text = "Message here";
            this.YouHaveDouble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YesBtn
            // 
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.YesBtn.Location = new System.Drawing.Point(109, 116);
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
            this.NoBtn.Location = new System.Drawing.Point(372, 116);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(75, 23);
            this.NoBtn.TabIndex = 2;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // UpdateOwnedBWG
            // 
            this.UpdateOwnedBWG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpdateOwnedBWG_DoWork);
            // 
            // AddToDoubleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(559, 156);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.YouHaveDouble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddToDoubleFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YouHaveDouble;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.ComponentModel.BackgroundWorker UpdateOwnedBWG;
    }
}