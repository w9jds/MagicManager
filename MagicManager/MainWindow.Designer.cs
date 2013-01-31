namespace MagicManager
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchResultsView = new System.Windows.Forms.DataGridView();
            this.CardSearchBox = new System.Windows.Forms.TextBox();
            this.MultiverseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNameExpansion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyCards = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCards)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(838, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preferencesToolStripMenuItem.Text = "Settings";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // SearchResultsView
            // 
            this.SearchResultsView.AllowUserToAddRows = false;
            this.SearchResultsView.AllowUserToDeleteRows = false;
            this.SearchResultsView.AllowUserToResizeColumns = false;
            this.SearchResultsView.AllowUserToResizeRows = false;
            this.SearchResultsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultsView.ColumnHeadersVisible = false;
            this.SearchResultsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MultiverseID,
            this.CardNameExpansion});
            this.SearchResultsView.Location = new System.Drawing.Point(12, 77);
            this.SearchResultsView.MultiSelect = false;
            this.SearchResultsView.Name = "SearchResultsView";
            this.SearchResultsView.ReadOnly = true;
            this.SearchResultsView.RowHeadersVisible = false;
            this.SearchResultsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResultsView.Size = new System.Drawing.Size(378, 424);
            this.SearchResultsView.TabIndex = 2;
            this.SearchResultsView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResultsView_CellDoubleClick);
            // 
            // CardSearchBox
            // 
            this.CardSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardSearchBox.Location = new System.Drawing.Point(12, 43);
            this.CardSearchBox.Name = "CardSearchBox";
            this.CardSearchBox.Size = new System.Drawing.Size(378, 26);
            this.CardSearchBox.TabIndex = 3;
            this.CardSearchBox.TextChanged += new System.EventHandler(this.CardSearchBox_TextChanged);
            // 
            // MultiverseID
            // 
            this.MultiverseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.MultiverseID.HeaderText = "ID";
            this.MultiverseID.Name = "MultiverseID";
            this.MultiverseID.ReadOnly = true;
            this.MultiverseID.Width = 5;
            // 
            // CardNameExpansion
            // 
            this.CardNameExpansion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CardNameExpansion.HeaderText = "Name";
            this.CardNameExpansion.Name = "CardNameExpansion";
            this.CardNameExpansion.ReadOnly = true;
            this.CardNameExpansion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MyCards
            // 
            this.MyCards.AllowUserToAddRows = false;
            this.MyCards.AllowUserToDeleteRows = false;
            this.MyCards.AllowUserToResizeColumns = false;
            this.MyCards.AllowUserToResizeRows = false;
            this.MyCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyCards.ColumnHeadersVisible = false;
            this.MyCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.MyCards.Location = new System.Drawing.Point(448, 77);
            this.MyCards.MultiSelect = false;
            this.MyCards.Name = "MyCards";
            this.MyCards.ReadOnly = true;
            this.MyCards.RowHeadersVisible = false;
            this.MyCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyCards.Size = new System.Drawing.Size(378, 424);
            this.MyCards.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(838, 513);
            this.Controls.Add(this.MyCards);
            this.Controls.Add(this.CardSearchBox);
            this.Controls.Add(this.SearchResultsView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.DataGridView SearchResultsView;
        private System.Windows.Forms.TextBox CardSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MultiverseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNameExpansion;
        private System.Windows.Forms.DataGridView MyCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

