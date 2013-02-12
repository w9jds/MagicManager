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
            this.deckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchResultsView = new System.Windows.Forms.DataGridView();
            this.MultiverseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNameExpansion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardSearchBox = new System.Windows.Forms.TextBox();
            this.MyCards = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ExpansionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpanCheck = new System.Windows.Forms.CheckBox();
            this.NameCheck = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RarityCheck = new System.Windows.Forms.CheckBox();
            this.RarityLabel = new System.Windows.Forms.Label();
            this.CardsBGW = new System.ComponentModel.BackgroundWorker();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.OwnedCardsBGW = new System.ComponentModel.BackgroundWorker();
            this.SearchBGW = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCards)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1017, 24);
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
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deckToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // deckToolStripMenuItem
            // 
            this.deckToolStripMenuItem.Name = "deckToolStripMenuItem";
            this.deckToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.deckToolStripMenuItem.Text = "Deck";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
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
            this.SearchResultsView.Location = new System.Drawing.Point(333, 75);
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
            this.SearchResultsView.Size = new System.Drawing.Size(307, 426);
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
            this.CardSearchBox.Location = new System.Drawing.Point(34, 75);
            this.CardSearchBox.Name = "CardSearchBox";
            this.CardSearchBox.Size = new System.Drawing.Size(285, 26);
            this.CardSearchBox.TabIndex = 3;
            // 
            // MyCards
            // 
            this.MyCards.AllowUserToAddRows = false;
            this.MyCards.AllowUserToDeleteRows = false;
            this.MyCards.AllowUserToResizeColumns = false;
            this.MyCards.AllowUserToResizeRows = false;
            this.MyCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyCards.ColumnHeadersVisible = false;
            this.MyCards.Location = new System.Drawing.Point(698, 75);
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
            this.MyCards.Size = new System.Drawing.Size(307, 426);
            this.MyCards.TabIndex = 4;
            this.MyCards.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyCards_CellDoubleClick);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Location = new System.Drawing.Point(646, 261);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(46, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Location = new System.Drawing.Point(116, 451);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(9, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // ExpansionBox
            // 
            this.ExpansionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpansionBox.Location = new System.Drawing.Point(34, 140);
            this.ExpansionBox.Name = "ExpansionBox";
            this.ExpansionBox.Size = new System.Drawing.Size(285, 26);
            this.ExpansionBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Expansion:";
            // 
            // ExpanCheck
            // 
            this.ExpanCheck.AutoSize = true;
            this.ExpanCheck.Location = new System.Drawing.Point(12, 146);
            this.ExpanCheck.Name = "ExpanCheck";
            this.ExpanCheck.Size = new System.Drawing.Size(15, 14);
            this.ExpanCheck.TabIndex = 11;
            this.ExpanCheck.UseVisualStyleBackColor = true;
            // 
            // NameCheck
            // 
            this.NameCheck.AutoSize = true;
            this.NameCheck.Location = new System.Drawing.Point(12, 81);
            this.NameCheck.Name = "NameCheck";
            this.NameCheck.Size = new System.Drawing.Size(15, 14);
            this.NameCheck.TabIndex = 12;
            this.NameCheck.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Timeshifted",
            "Mythic Rare"});
            this.comboBox1.Location = new System.Drawing.Point(34, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // RarityCheck
            // 
            this.RarityCheck.AutoSize = true;
            this.RarityCheck.Location = new System.Drawing.Point(12, 379);
            this.RarityCheck.Name = "RarityCheck";
            this.RarityCheck.Size = new System.Drawing.Size(15, 14);
            this.RarityCheck.TabIndex = 14;
            this.RarityCheck.UseVisualStyleBackColor = true;
            // 
            // RarityLabel
            // 
            this.RarityLabel.AutoSize = true;
            this.RarityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RarityLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RarityLabel.Location = new System.Drawing.Point(9, 354);
            this.RarityLabel.Name = "RarityLabel";
            this.RarityLabel.Size = new System.Drawing.Size(49, 17);
            this.RarityLabel.TabIndex = 15;
            this.RarityLabel.Text = "Rarity:";
            this.RarityLabel.UseMnemonic = false;
            // 
            // CardsBGW
            // 
            this.CardsBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CardsBGW_DoWork);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 515);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1017, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 16;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // OwnedCardsBGW
            // 
            this.OwnedCardsBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OwnedCardsBGW_DoWork);
            // 
            // SearchBGW
            // 
            this.SearchBGW.WorkerSupportsCancellation = true;
            this.SearchBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchBGW_DoWork);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1017, 537);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.RarityLabel);
            this.Controls.Add(this.RarityCheck);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NameCheck);
            this.Controls.Add(this.ExpanCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpansionBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MyCards);
            this.Controls.Add(this.CardSearchBox);
            this.Controls.Add(this.SearchResultsView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCards)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
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
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MultiverseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNameExpansion;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridView MyCards;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ExpansionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ExpanCheck;
        private System.Windows.Forms.CheckBox NameCheck;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox RarityCheck;
        private System.Windows.Forms.Label RarityLabel;
        private System.ComponentModel.BackgroundWorker CardsBGW;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.ComponentModel.BackgroundWorker OwnedCardsBGW;
        private System.ComponentModel.BackgroundWorker SearchBGW;
    }
}

