namespace MagicManager
{
    partial class LegalityWin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LegalityView = new System.Windows.Forms.DataGridView();
            this.CardFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNameExpansion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LegalityView)).BeginInit();
            this.SuspendLayout();
            // 
            // LegalityView
            // 
            this.LegalityView.AllowUserToAddRows = false;
            this.LegalityView.AllowUserToDeleteRows = false;
            this.LegalityView.AllowUserToResizeColumns = false;
            this.LegalityView.AllowUserToResizeRows = false;
            this.LegalityView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LegalityView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LegalityView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LegalityView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LegalityView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardFormat,
            this.CardNameExpansion});
            this.LegalityView.Location = new System.Drawing.Point(12, 12);
            this.LegalityView.MultiSelect = false;
            this.LegalityView.Name = "LegalityView";
            this.LegalityView.ReadOnly = true;
            this.LegalityView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LegalityView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LegalityView.RowHeadersVisible = false;
            this.LegalityView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LegalityView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LegalityView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LegalityView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegalityView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.LegalityView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.LegalityView.RowTemplate.ReadOnly = true;
            this.LegalityView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LegalityView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LegalityView.ShowEditingIcon = false;
            this.LegalityView.ShowRowErrors = false;
            this.LegalityView.Size = new System.Drawing.Size(510, 424);
            this.LegalityView.TabIndex = 3;
            // 
            // CardFormat
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CardFormat.DefaultCellStyle = dataGridViewCellStyle2;
            this.CardFormat.HeaderText = "Format";
            this.CardFormat.Name = "CardFormat";
            this.CardFormat.ReadOnly = true;
            this.CardFormat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CardFormat.Width = 255;
            // 
            // CardNameExpansion
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CardNameExpansion.DefaultCellStyle = dataGridViewCellStyle3;
            this.CardNameExpansion.HeaderText = "Legality";
            this.CardNameExpansion.Name = "CardNameExpansion";
            this.CardNameExpansion.ReadOnly = true;
            this.CardNameExpansion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CardNameExpansion.Width = 254;
            // 
            // LegalityWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(534, 448);
            this.Controls.Add(this.LegalityView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(550, 487);
            this.Name = "LegalityWin";
            ((System.ComponentModel.ISupportInitialize)(this.LegalityView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LegalityView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNameExpansion;
    }
}