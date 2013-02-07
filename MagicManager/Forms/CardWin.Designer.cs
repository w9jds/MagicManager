namespace MagicManager
{
    partial class CardWin
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
            this.CardPic = new System.Windows.Forms.PictureBox();
            this.CardName = new System.Windows.Forms.TextBox();
            this.ConvMana = new System.Windows.Forms.TextBox();
            this.CardType = new System.Windows.Forms.TextBox();
            this.PowerToughness = new System.Windows.Forms.TextBox();
            this.Expansion = new System.Windows.Forms.TextBox();
            this.Rarity = new System.Windows.Forms.TextBox();
            this.ViewLegalityBtn = new System.Windows.Forms.Button();
            this.ViewCostBtn = new System.Windows.Forms.Button();
            this.CardInfoBGW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.CardPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CardPic
            // 
            this.CardPic.Location = new System.Drawing.Point(12, 12);
            this.CardPic.Name = "CardPic";
            this.CardPic.Size = new System.Drawing.Size(223, 310);
            this.CardPic.TabIndex = 0;
            this.CardPic.TabStop = false;
            // 
            // CardName
            // 
            this.CardName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.ForeColor = System.Drawing.SystemColors.Window;
            this.CardName.Location = new System.Drawing.Point(241, 25);
            this.CardName.Name = "CardName";
            this.CardName.ReadOnly = true;
            this.CardName.Size = new System.Drawing.Size(397, 19);
            this.CardName.TabIndex = 3;
            this.CardName.TabStop = false;
            this.CardName.Text = "Card Name";
            this.CardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvMana
            // 
            this.ConvMana.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConvMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConvMana.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConvMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvMana.ForeColor = System.Drawing.SystemColors.Window;
            this.ConvMana.Location = new System.Drawing.Point(241, 57);
            this.ConvMana.Name = "ConvMana";
            this.ConvMana.ReadOnly = true;
            this.ConvMana.Size = new System.Drawing.Size(397, 16);
            this.ConvMana.TabIndex = 4;
            this.ConvMana.TabStop = false;
            this.ConvMana.Text = "Converted Mana Cost";
            this.ConvMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardType
            // 
            this.CardType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CardType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardType.ForeColor = System.Drawing.SystemColors.Window;
            this.CardType.Location = new System.Drawing.Point(241, 79);
            this.CardType.Name = "CardType";
            this.CardType.ReadOnly = true;
            this.CardType.Size = new System.Drawing.Size(397, 16);
            this.CardType.TabIndex = 5;
            this.CardType.TabStop = false;
            this.CardType.Text = "Type";
            this.CardType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PowerToughness
            // 
            this.PowerToughness.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PowerToughness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PowerToughness.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PowerToughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerToughness.ForeColor = System.Drawing.SystemColors.Window;
            this.PowerToughness.Location = new System.Drawing.Point(241, 218);
            this.PowerToughness.Name = "PowerToughness";
            this.PowerToughness.ReadOnly = true;
            this.PowerToughness.Size = new System.Drawing.Size(397, 16);
            this.PowerToughness.TabIndex = 6;
            this.PowerToughness.TabStop = false;
            this.PowerToughness.Text = "Power and Toughness";
            this.PowerToughness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Expansion
            // 
            this.Expansion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Expansion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Expansion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Expansion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expansion.ForeColor = System.Drawing.SystemColors.Window;
            this.Expansion.Location = new System.Drawing.Point(241, 240);
            this.Expansion.Name = "Expansion";
            this.Expansion.ReadOnly = true;
            this.Expansion.Size = new System.Drawing.Size(397, 16);
            this.Expansion.TabIndex = 7;
            this.Expansion.TabStop = false;
            this.Expansion.Text = "Expansion";
            this.Expansion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rarity
            // 
            this.Rarity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Rarity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rarity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Rarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rarity.ForeColor = System.Drawing.SystemColors.Window;
            this.Rarity.Location = new System.Drawing.Point(241, 262);
            this.Rarity.Name = "Rarity";
            this.Rarity.ReadOnly = true;
            this.Rarity.Size = new System.Drawing.Size(397, 16);
            this.Rarity.TabIndex = 8;
            this.Rarity.TabStop = false;
            this.Rarity.Text = "Rarity";
            this.Rarity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewLegalityBtn
            // 
            this.ViewLegalityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewLegalityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLegalityBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewLegalityBtn.Location = new System.Drawing.Point(250, 300);
            this.ViewLegalityBtn.Name = "ViewLegalityBtn";
            this.ViewLegalityBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewLegalityBtn.TabIndex = 9;
            this.ViewLegalityBtn.Text = "Legality";
            this.ViewLegalityBtn.UseVisualStyleBackColor = true;
            this.ViewLegalityBtn.Click += new System.EventHandler(this.ViewLegalityBtn_Click);
            // 
            // ViewCostBtn
            // 
            this.ViewCostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewCostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCostBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewCostBtn.Location = new System.Drawing.Point(563, 300);
            this.ViewCostBtn.Name = "ViewCostBtn";
            this.ViewCostBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewCostBtn.TabIndex = 10;
            this.ViewCostBtn.Text = "Cost";
            this.ViewCostBtn.UseVisualStyleBackColor = true;
            this.ViewCostBtn.Click += new System.EventHandler(this.ViewCostBtn_Click);
            // 
            // CardInfoBGW
            // 
            this.CardInfoBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CardInfoBGW_DoWork);
            // 
            // CardWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(650, 335);
            this.Controls.Add(this.ViewCostBtn);
            this.Controls.Add(this.ViewLegalityBtn);
            this.Controls.Add(this.Rarity);
            this.Controls.Add(this.Expansion);
            this.Controls.Add(this.PowerToughness);
            this.Controls.Add(this.CardType);
            this.Controls.Add(this.ConvMana);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.CardPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 374);
            this.MinimumSize = new System.Drawing.Size(666, 374);
            this.Name = "CardWin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.CardPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CardPic;
        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox ConvMana;
        private System.Windows.Forms.TextBox CardType;
        private System.Windows.Forms.TextBox PowerToughness;
        private System.Windows.Forms.TextBox Expansion;
        private System.Windows.Forms.TextBox Rarity;
        private System.Windows.Forms.Button ViewLegalityBtn;
        private System.Windows.Forms.Button ViewCostBtn;
        private System.ComponentModel.BackgroundWorker CardInfoBGW;
    }
}