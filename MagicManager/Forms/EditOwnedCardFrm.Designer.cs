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
            this.CardName.Size = new System.Drawing.Size(420, 16);
            this.CardName.TabIndex = 0;
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
            this.CardExpansion.Size = new System.Drawing.Size(420, 14);
            this.CardExpansion.TabIndex = 1;
            this.CardExpansion.Text = "Expansion";
            this.CardExpansion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditOwnedCardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(444, 261);
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
    }
}