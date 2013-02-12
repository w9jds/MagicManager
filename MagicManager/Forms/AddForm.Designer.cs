namespace MagicManager
{
    partial class AddForm
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.NormMulti = new System.Windows.Forms.TextBox();
            this.CardExpansion = new System.Windows.Forms.TextBox();
            this.FoilCombo = new System.Windows.Forms.ComboBox();
            this.FoilLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AmountFoilLabel = new System.Windows.Forms.Label();
            this.FoilAmount = new System.Windows.Forms.TextBox();
            this.CardInfoBGW = new System.ComponentModel.BackgroundWorker();
            this.AddToOwnedBGW = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // CardName
            // 
            this.CardName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.ForeColor = System.Drawing.SystemColors.Window;
            this.CardName.Location = new System.Drawing.Point(12, 12);
            this.CardName.Name = "CardName";
            this.CardName.ReadOnly = true;
            this.CardName.Size = new System.Drawing.Size(488, 19);
            this.CardName.TabIndex = 0;
            this.CardName.TabStop = false;
            this.CardName.Text = "CardName";
            this.CardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CardName.WordWrap = false;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AmountLabel.Location = new System.Drawing.Point(178, 83);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(157, 17);
            this.AmountLabel.TabIndex = 1;
            this.AmountLabel.Text = "How many do you own?";
            // 
            // NormMulti
            // 
            this.NormMulti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NormMulti.Location = new System.Drawing.Point(206, 103);
            this.NormMulti.Name = "NormMulti";
            this.NormMulti.Size = new System.Drawing.Size(100, 20);
            this.NormMulti.TabIndex = 2;
            this.NormMulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NormMulti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NormMulti_KeyPress);
            // 
            // CardExpansion
            // 
            this.CardExpansion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CardExpansion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardExpansion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CardExpansion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardExpansion.ForeColor = System.Drawing.SystemColors.Window;
            this.CardExpansion.Location = new System.Drawing.Point(12, 37);
            this.CardExpansion.Name = "CardExpansion";
            this.CardExpansion.ReadOnly = true;
            this.CardExpansion.Size = new System.Drawing.Size(488, 16);
            this.CardExpansion.TabIndex = 3;
            this.CardExpansion.TabStop = false;
            this.CardExpansion.Text = "Expansion";
            this.CardExpansion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FoilCombo
            // 
            this.FoilCombo.FormattingEnabled = true;
            this.FoilCombo.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.FoilCombo.Location = new System.Drawing.Point(206, 153);
            this.FoilCombo.Name = "FoilCombo";
            this.FoilCombo.Size = new System.Drawing.Size(100, 21);
            this.FoilCombo.TabIndex = 5;
            this.FoilCombo.SelectedIndexChanged += new System.EventHandler(this.FoilCombo_SelectedIndexChanged);
            // 
            // FoilLabel
            // 
            this.FoilLabel.AutoSize = true;
            this.FoilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoilLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FoilLabel.Location = new System.Drawing.Point(185, 133);
            this.FoilLabel.Name = "FoilLabel";
            this.FoilLabel.Size = new System.Drawing.Size(142, 17);
            this.FoilLabel.TabIndex = 6;
            this.FoilLabel.Text = "Are any of them Foil?";
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBtn.Location = new System.Drawing.Point(122, 277);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelBtn.Location = new System.Drawing.Point(308, 277);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AmountFoilLabel
            // 
            this.AmountFoilLabel.AutoSize = true;
            this.AmountFoilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountFoilLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AmountFoilLabel.Location = new System.Drawing.Point(216, 183);
            this.AmountFoilLabel.Name = "AmountFoilLabel";
            this.AmountFoilLabel.Size = new System.Drawing.Size(81, 17);
            this.AmountFoilLabel.TabIndex = 9;
            this.AmountFoilLabel.Text = "How Many?";
            this.AmountFoilLabel.Visible = false;
            // 
            // FoilAmount
            // 
            this.FoilAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoilAmount.Location = new System.Drawing.Point(206, 203);
            this.FoilAmount.Name = "FoilAmount";
            this.FoilAmount.Size = new System.Drawing.Size(100, 20);
            this.FoilAmount.TabIndex = 10;
            this.FoilAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FoilAmount.Visible = false;
            this.FoilAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoilAmount_KeyPress);
            // 
            // CardInfoBGW
            // 
            this.CardInfoBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CardInfoBGW_DoWork);
            // 
            // AddToOwnedBGW
            // 
            this.AddToOwnedBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AddToOwnedBGW_DoWork);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(513, 337);
            this.Controls.Add(this.FoilAmount);
            this.Controls.Add(this.AmountFoilLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FoilLabel);
            this.Controls.Add(this.FoilCombo);
            this.Controls.Add(this.CardExpansion);
            this.Controls.Add(this.NormMulti);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CardName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox NormMulti;
        private System.Windows.Forms.TextBox CardExpansion;
        private System.Windows.Forms.ComboBox FoilCombo;
        private System.Windows.Forms.Label FoilLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label AmountFoilLabel;
        private System.Windows.Forms.TextBox FoilAmount;
        private System.ComponentModel.BackgroundWorker CardInfoBGW;
        private System.ComponentModel.BackgroundWorker AddToOwnedBGW;
    }
}