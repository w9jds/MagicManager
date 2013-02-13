namespace MagicManager
{
    partial class EditOwnedCardFrm
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
            this.CardName = new System.Windows.Forms.TextBox();
            this.CardExpansion = new System.Windows.Forms.TextBox();
            this.StdAmount = new System.Windows.Forms.TextBox();
            this.FoilAmount = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.StdLabel = new System.Windows.Forms.Label();
            this.FoilLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardName
            // 
            this.CardName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardName.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.ForeColor = System.Drawing.SystemColors.Window;
            this.CardName.Location = new System.Drawing.Point(12, 12);
            this.CardName.Name = "CardName";
            this.CardName.ReadOnly = true;
            this.CardName.Size = new System.Drawing.Size(354, 16);
            this.CardName.TabIndex = 0;
            this.CardName.TabStop = false;
            this.CardName.Text = "Card Name";
            this.CardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardExpansion
            // 
            this.CardExpansion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CardExpansion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardExpansion.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardExpansion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardExpansion.ForeColor = System.Drawing.SystemColors.Window;
            this.CardExpansion.Location = new System.Drawing.Point(12, 39);
            this.CardExpansion.Name = "CardExpansion";
            this.CardExpansion.ReadOnly = true;
            this.CardExpansion.Size = new System.Drawing.Size(354, 14);
            this.CardExpansion.TabIndex = 1;
            this.CardExpansion.TabStop = false;
            this.CardExpansion.Text = "Expansion";
            this.CardExpansion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StdAmount
            // 
            this.StdAmount.Location = new System.Drawing.Point(139, 106);
            this.StdAmount.Name = "StdAmount";
            this.StdAmount.Size = new System.Drawing.Size(100, 20);
            this.StdAmount.TabIndex = 2;
            this.StdAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FoilAmount
            // 
            this.FoilAmount.Location = new System.Drawing.Point(139, 155);
            this.FoilAmount.Name = "FoilAmount";
            this.FoilAmount.Size = new System.Drawing.Size(100, 20);
            this.FoilAmount.TabIndex = 3;
            this.FoilAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveBtn.Location = new System.Drawing.Point(62, 209);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelBtn.Location = new System.Drawing.Point(238, 209);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StdLabel
            // 
            this.StdLabel.AutoSize = true;
            this.StdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdLabel.Location = new System.Drawing.Point(161, 88);
            this.StdLabel.Name = "StdLabel";
            this.StdLabel.Size = new System.Drawing.Size(57, 15);
            this.StdLabel.TabIndex = 6;
            this.StdLabel.Text = "Standard";
            // 
            // FoilLabel
            // 
            this.FoilLabel.AutoSize = true;
            this.FoilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoilLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FoilLabel.Location = new System.Drawing.Point(176, 137);
            this.FoilLabel.Name = "FoilLabel";
            this.FoilLabel.Size = new System.Drawing.Size(27, 15);
            this.FoilLabel.TabIndex = 7;
            this.FoilLabel.Text = "Foil";
            // 
            // EditOwnedCardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.FoilLabel);
            this.Controls.Add(this.StdLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FoilAmount);
            this.Controls.Add(this.StdAmount);
            this.Controls.Add(this.CardExpansion);
            this.Controls.Add(this.CardName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditOwnedCardFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox CardExpansion;
        private System.Windows.Forms.TextBox StdAmount;
        private System.Windows.Forms.TextBox FoilAmount;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label StdLabel;
        private System.Windows.Forms.Label FoilLabel;
    }
}