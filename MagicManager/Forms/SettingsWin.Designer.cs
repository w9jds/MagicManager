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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MyLabel = new System.Windows.Forms.Label();
            this.MyDBPath = new System.Windows.Forms.TextBox();
            this.SearchButton1 = new System.Windows.Forms.Button();
            this.OpenMyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // DatabaseLocLabel
            // 
            this.DatabaseLocLabel.AutoSize = true;
            this.DatabaseLocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseLocLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DatabaseLocLabel.Location = new System.Drawing.Point(12, 31);
            this.DatabaseLocLabel.Name = "DatabaseLocLabel";
            this.DatabaseLocLabel.Size = new System.Drawing.Size(118, 17);
            this.DatabaseLocLabel.TabIndex = 0;
            this.DatabaseLocLabel.Text = "Cards Database: ";
            // 
            // DatabasePath
            // 
            this.DatabasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabasePath.Location = new System.Drawing.Point(136, 28);
            this.DatabasePath.Name = "DatabasePath";
            this.DatabasePath.Size = new System.Drawing.Size(309, 23);
            this.DatabasePath.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(460, 28);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "...";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(130, 189);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(299, 189);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.Filter = "Magic Manager Card Database |*.mmcdb";
            this.OpenFileDialog.Title = "Select the Card Database";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // MyLabel
            // 
            this.MyLabel.AutoSize = true;
            this.MyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyLabel.Location = new System.Drawing.Point(12, 97);
            this.MyLabel.Name = "MyLabel";
            this.MyLabel.Size = new System.Drawing.Size(140, 17);
            this.MyLabel.TabIndex = 5;
            this.MyLabel.Text = "My Cards Database: ";
            // 
            // MyDBPath
            // 
            this.MyDBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDBPath.Location = new System.Drawing.Point(158, 94);
            this.MyDBPath.Name = "MyDBPath";
            this.MyDBPath.Size = new System.Drawing.Size(287, 23);
            this.MyDBPath.TabIndex = 6;
            // 
            // SearchButton1
            // 
            this.SearchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton1.Location = new System.Drawing.Point(460, 94);
            this.SearchButton1.Name = "SearchButton1";
            this.SearchButton1.Size = new System.Drawing.Size(28, 23);
            this.SearchButton1.TabIndex = 7;
            this.SearchButton1.Text = "...";
            this.SearchButton1.UseVisualStyleBackColor = true;
            this.SearchButton1.Click += new System.EventHandler(this.SearchButton1_Click);
            // 
            // OpenMyFileDialog
            // 
            this.OpenMyFileDialog.FileName = "OpenMyFileDialog";
            this.OpenMyFileDialog.Filter = "Magic Manager Owned Database |*.mmodb";
            this.OpenMyFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenMyFileDialog_FileOk);
            // 
            // SettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(500, 224);
            this.Controls.Add(this.SearchButton1);
            this.Controls.Add(this.MyDBPath);
            this.Controls.Add(this.MyLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DatabasePath);
            this.Controls.Add(this.DatabaseLocLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SettingsWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatabaseLocLabel;
        private System.Windows.Forms.TextBox DatabasePath;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label MyLabel;
        private System.Windows.Forms.TextBox MyDBPath;
        private System.Windows.Forms.Button SearchButton1;
        private System.Windows.Forms.OpenFileDialog OpenMyFileDialog;
    }
}