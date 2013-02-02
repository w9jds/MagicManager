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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchResultsView = new System.Windows.Forms.DataGridView();
            this.MultiverseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNameExpansion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardSearchBox = new System.Windows.Forms.TextBox();
            this.MyCards = new System.Windows.Forms.DataGridView();
            this.MyWantCards = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.MultiverseID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdOwned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoilOwned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyWantCards)).BeginInit();
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
            this.saveToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ownedToolStripMenuItem,
            this.wantToolStripMenuItem,
            this.bothToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // ownedToolStripMenuItem
            // 
            this.ownedToolStripMenuItem.Name = "ownedToolStripMenuItem";
            this.ownedToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ownedToolStripMenuItem.Text = "Owned";
            // 
            // wantToolStripMenuItem
            // 
            this.wantToolStripMenuItem.Name = "wantToolStripMenuItem";
            this.wantToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.wantToolStripMenuItem.Text = "Want";
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.bothToolStripMenuItem.Text = "Both";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.preferencesToolStripMenuItem.Text = "Settings";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // SearchResultsView
            // 
            this.SearchResultsView.AllowUserToAddRows = false;
            this.SearchResultsView.AllowUserToDeleteRows = false;
            this.SearchResultsView.AllowUserToResizeColumns = false;
            this.SearchResultsView.AllowUserToResizeRows = false;
            this.SearchResultsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
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
            this.SearchResultsView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SearchResultsView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SearchResultsView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResultsView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.SearchResultsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResultsView.ShowEditingIcon = false;
            this.SearchResultsView.ShowRowErrors = false;
            this.SearchResultsView.Size = new System.Drawing.Size(378, 424);
            this.SearchResultsView.TabIndex = 2;
            this.SearchResultsView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResultsView_CellDoubleClick);
            // 
            // MultiverseID
            // 
            this.MultiverseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.MultiverseID.HeaderText = "ID";
            this.MultiverseID.Name = "MultiverseID";
            this.MultiverseID.ReadOnly = true;
            this.MultiverseID.Visible = false;
            // 
            // CardNameExpansion
            // 
            this.CardNameExpansion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CardNameExpansion.HeaderText = "Name";
            this.CardNameExpansion.Name = "CardNameExpansion";
            this.CardNameExpansion.ReadOnly = true;
            this.CardNameExpansion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // MyCards
            // 
            this.MyCards.AllowUserToAddRows = false;
            this.MyCards.AllowUserToDeleteRows = false;
            this.MyCards.AllowUserToResizeColumns = false;
            this.MyCards.AllowUserToResizeRows = false;
            this.MyCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyCards.ColumnHeadersVisible = false;
            this.MyCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MultiverseID1,
            this.NameCard,
            this.Expan,
            this.StdOwned,
            this.FoilOwned});
            this.MyCards.Location = new System.Drawing.Point(448, 77);
            this.MyCards.MultiSelect = false;
            this.MyCards.Name = "MyCards";
            this.MyCards.ReadOnly = true;
            this.MyCards.RowHeadersVisible = false;
            this.MyCards.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MyCards.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MyCards.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCards.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.MyCards.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MyCards.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MyCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyCards.Size = new System.Drawing.Size(378, 205);
            this.MyCards.TabIndex = 4;
            this.MyCards.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyCards_CellDoubleClick);
            // 
            // MyWantCards
            // 
            this.MyWantCards.AllowUserToAddRows = false;
            this.MyWantCards.AllowUserToDeleteRows = false;
            this.MyWantCards.AllowUserToResizeColumns = false;
            this.MyWantCards.AllowUserToResizeRows = false;
            this.MyWantCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyWantCards.ColumnHeadersVisible = false;
            this.MyWantCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.MyWantCards.Location = new System.Drawing.Point(448, 298);
            this.MyWantCards.MultiSelect = false;
            this.MyWantCards.Name = "MyWantCards";
            this.MyWantCards.ReadOnly = true;
            this.MyWantCards.RowHeadersVisible = false;
            this.MyWantCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyWantCards.Size = new System.Drawing.Size(378, 203);
            this.MyWantCards.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Location = new System.Drawing.Point(396, 177);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(46, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MultiverseID1
            // 
            this.MultiverseID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.MultiverseID1.HeaderText = "ID";
            this.MultiverseID1.Name = "MultiverseID1";
            this.MultiverseID1.ReadOnly = true;
            this.MultiverseID1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MultiverseID1.Visible = false;
            this.MultiverseID1.Width = 5;
            // 
            // NameCard
            // 
            this.NameCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.NameCard.HeaderText = "Name";
            this.NameCard.Name = "NameCard";
            this.NameCard.ReadOnly = true;
            this.NameCard.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameCard.Width = 5;
            // 
            // Expan
            // 
            this.Expan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Expan.HeaderText = "Expansion";
            this.Expan.Name = "Expan";
            this.Expan.ReadOnly = true;
            this.Expan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Expan.Width = 5;
            // 
            // StdOwned
            // 
            this.StdOwned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.StdOwned.HeaderText = "Standard";
            this.StdOwned.Name = "StdOwned";
            this.StdOwned.ReadOnly = true;
            this.StdOwned.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StdOwned.Width = 5;
            // 
            // FoilOwned
            // 
            this.FoilOwned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FoilOwned.HeaderText = "Foils";
            this.FoilOwned.Name = "FoilOwned";
            this.FoilOwned.ReadOnly = true;
            this.FoilOwned.Width = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(838, 513);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MyWantCards);
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
            ((System.ComponentModel.ISupportInitialize)(this.MyWantCards)).EndInit();
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
        private System.Windows.Forms.DataGridView MyWantCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MultiverseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNameExpansion;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
        public System.Windows.Forms.DataGridView MyCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn MultiverseID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expan;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdOwned;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoilOwned;
    }
}

