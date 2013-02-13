using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicManager
{
    public partial class MainWindow : Form
    {
        private List<string> CardMultiverseID = new List<string>();
        private List<string> CardName = new List<string>();
        private List<string> CardExpansion = new List<string>();
        private List<string> CardImgURL = new List<string>();

        public MainWindow()
        {   
            InitializeComponent();
            this.TopLevel = true;
            MyCards.ContextMenuStrip = MyCardsContextMenu;
            updateDB();
            checkOwnedDB();
        }

        public void checkOwnedDB()
        {
            if (Properties.Settings.Default.OwnedDatabase == "" || System.IO.File.Exists(Properties.Settings.Default.OwnedDatabase) == false)
            {
                MagicManager.Forms.WantNewDBForm Ask = new MagicManager.Forms.WantNewDBForm(this);
                Ask.Show();
            }
            else
                updateODB();
        }

        public void updateDB()
        {
            CardsBGW.RunWorkerAsync();
        }

        public void updateODB()
        {
            OwnedCardsBGW.RunWorkerAsync();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWin setSettings = new SettingsWin(this);
            setSettings.Show();
        }

        private void SearchResultsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int multiverseid = Convert.ToInt32(SearchResultsView.Rows[e.RowIndex].Cells["MultiverseID"].Value.ToString());
            CardWin Card = new CardWin(multiverseid);
            Card.Show();
        }
        
        private void MyCards_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int multiverseid = Convert.ToInt32(MyCards[0, e.RowIndex].Value.ToString());
            CardWin Card = new CardWin(multiverseid);
            Card.Show();
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = SearchResultsView.SelectedRows[0];
            int multiverseid = Convert.ToInt32(SearchResultsView.Rows[row.Index].Cells["MultiverseID"].Value.ToString());
            AddForm AddCardForm = new AddForm(multiverseid, this);
            AddCardForm.Show();
        }

        private void AddOwnedCard(string[] Card, int stdOwned, int foilOwned)
        {
            MyCards.Rows.Add(Card[0], Card[1], Card[7], stdOwned, foilOwned);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!SearchBGW.IsBusy)
                SearchBGW.RunWorkerAsync();
        }

        private void CardsBGW_DoWork(object sender, DoWorkEventArgs e)
        {            
            try
            {
                OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.DatabaseLocation);
                DBCon.Open();

                OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT MultiverseID, Name, Expansion FROM Cards", DBCon);
                DataSet CardDS = new DataSet();
                CardDA.Fill(CardDS);
                DataTable CardDT = CardDS.Tables[0];
                DBCon.Close();

                for (int i = 0; i < CardDT.Rows.Count; i++)
                {  
                    CardMultiverseID.Add(CardDT.Rows[i]["MultiverseID"].ToString());
                    CardName.Add(CardDT.Rows[i]["Name"].ToString());
                    CardExpansion.Add(CardDT.Rows[i]["Expansion"].ToString());
                    //CardImgURL.Add(CardDT.Rows[i]["ImgURL"].ToString());
                }
                
                SearchResultsView.Invoke((MethodInvoker)delegate{SearchResultsView.Rows.Clear();});
                for (int i = 0; i < CardName.Count; i++)
                    SearchResultsView.Invoke((MethodInvoker)delegate { SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [ " + CardExpansion[i] + " ]"); });
            }
            catch (Exception) {  }  
        }

        private void OwnedCardsBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<string[]> MyCardsList = new List<string[]>();
                
                
                OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.OwnedDatabase);
                DBCon.Open();

                OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT MultiverseID, Name, Expansion, stdAmount, foilAmount FROM MyCards", DBCon);
                DataSet CardDS = new DataSet();
                CardDA.Fill(CardDS);
                DBCon.Close();

                /*
                for (int i = 0; i < CardDS.Tables[0].Rows.Count; i++)
                {
                    string[] Card = new string[5];
                    for (int j = 0; j < CardDS.Tables[0].Columns.Count; j++)
                    {
                        Card[j] = CardDS.Tables[0].Rows[i][j].ToString();
                    }
                    MyCardsList.Add(Card);
                }

                MyCards.Invoke((MethodInvoker)delegate { MyCards.Rows.Clear(); });
                for (int i = 0; i < MyCardsList.Count; i++)
                {
                    MyCards.Invoke((MethodInvoker)delegate { MyCards.Rows.Add(MyCardsList[i]); });
                }
                */

                MyCards.Invoke((MethodInvoker)delegate { MyCards.DataSource = CardDS.Tables[0]; });
            }
            catch (Exception) { }  

        }

        private void SearchBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            SearchResultsView.Invoke((MethodInvoker)delegate { SearchResultsView.Rows.Clear(); });
            for (int i = 0; i < CardName.Count; i++)
            {
                if (NameCheck.Checked == true && ExpanCheck.Checked == false)
                {
                    if (CardName[i].IndexOf(CardSearchBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                        SearchResultsView.Invoke((MethodInvoker)delegate { SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [" + CardExpansion[i] + "]"); });
                }
                if (NameCheck.Checked == false && ExpanCheck.Checked == true)
                { 
                    if (CardExpansion[i].IndexOf(ExpansionBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                        SearchResultsView.Invoke((MethodInvoker)delegate { SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [" + CardExpansion[i] + "]"); });
                }
                if (NameCheck.Checked == true && ExpanCheck.Checked == true)
                {
                    if (CardName[i].IndexOf(CardSearchBox.Text, StringComparison.OrdinalIgnoreCase) != -1 && CardExpansion[i].IndexOf(ExpansionBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                        SearchResultsView.Invoke((MethodInvoker)delegate { SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [" + CardExpansion[i] + "]"); });
                }
            }
        }

        private void MyCards_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MyCards.Rows[e.RowIndex].Selected = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = MyCards.CurrentCell.RowIndex;
            EditOwnedCardFrm editCard = new EditOwnedCardFrm(MyCards[0, row].Value.ToString(), MyCards[1, row].Value.ToString(), MyCards[2, row].Value.ToString(), MyCards[3, row].Value.ToString(), MyCards[4, row].Value.ToString(), this);
            editCard.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WantToRemove ask = new WantToRemove(MyCards[1, MyCards.CurrentCell.RowIndex].Value.ToString(), MyCards[0, MyCards.CurrentCell.RowIndex].Value.ToString(), this);
            ask.Show();
        }
    }
}
