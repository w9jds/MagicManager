namespace MagicManager
{
    partial class SettingsWin
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
            this.DatabaseLocLabel = new System.Windows.Forms.Label();
            this.DatabasePath = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatabaseLocLabel
            // 
            this.DatabaseLocLabel.AutoSize = true;
            this.DatabaseLocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseLocLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DatabaseLocLabel.Location = new System.Drawing.Point(12, 30);
            this.DatabaseLocLabel.Name = "DatabaseLocLabel";
            this.DatabaseLocLabel.Size = new System.Drawing.Size(127, 17);
            this.DatabaseLocLabel.TabIndex = 0;
            this.DatabaseLocLabel.Text = "Database Location";
            // 
            // DatabasePath
            // 
            this.DatabasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabasePath.Location = new System.Drawing.Point(145, 27);
            this.DatabasePath.Name = "DatabasePath";
            this.DatabasePath.Size = new System.Drawing.Size(309, 23);
            this.DatabasePath.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(460, 27);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "...";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(523, 116);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DatabasePath);
            this.Controls.Add(this.DatabaseLocLabel);
            this.Name = "SettingsWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatabaseLocLabel;
        private System.Windows.Forms.TextBox DatabasePath;
        private System.Windows.Forms.Button SearchButton;
    }
}