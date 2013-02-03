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
        private List<int> CardMultiverseID = new List<int>();
        private List<string> CardName = new List<string>();
        private List<string> CardExpansion = new List<string>();
        private List<string> CardImgURL = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            updateDB();
        }

        public void updateDB()
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
                    CardMultiverseID.Add(Convert.ToInt32(CardDT.Rows[i]["MultiverseID"].ToString()));
                    CardName.Add(CardDT.Rows[i]["Name"].ToString());
                    CardExpansion.Add(CardDT.Rows[i]["Expansion"].ToString());
                    //CardImgURL.Add(CardDT.Rows[i]["ImgURL"].ToString());
                }

                for (int i = 0; i < CardName.Count; i++)
                {
                    SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [ " + CardExpansion[i] + " ]");
                }

            }
            catch (Exception) { }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWin setSettings = new SettingsWin(this);
            setSettings.Show();
        }

        private void CardSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchResultsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int multiverseid = Convert.ToInt32(SearchResultsView.Rows[e.RowIndex].Cells["MultiverseID"].Value.ToString());
            CardWin Card = new CardWin(multiverseid, this);
            Card.Show();
        }
        
        private void MyCards_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int multiverseid = Convert.ToInt32(MyCards.Rows[e.RowIndex].Cells["MultiverseID1"].Value.ToString());
            CardWin Card = new CardWin(multiverseid, this);
            Card.Show();
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = SearchResultsView.SelectedRows[0];
            int multiverseid = Convert.ToInt32(SearchResultsView.Rows[row.Index].Cells["MultiverseID"].Value.ToString());
            AddForm AddCardForm = new AddForm(multiverseid, this);
            AddCardForm.Show();
            
        }

        public void AddOwnedCard(string[] Card, int stdOwned, int foilOwned)
        {
            MyCards.Rows.Add(Card[0], Card[1], Card[7], stdOwned, foilOwned);
        }

        public string[] GetCardInfo(int multiverseid)
        {
            string[] Card = new string[10];

            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.DatabaseLocation);
            DBCon.Open();

            OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT * FROM Cards WHERE MultiverseID = '" + multiverseid + "'", DBCon);
            DataSet CardDS = new DataSet();
            CardDA.Fill(CardDS);
            DataTable CardDT = CardDS.Tables[0];
            DBCon.Close();

            for (int i = 0; i < CardDT.Rows.Count; i++)
            {
                for (int j = 0; j < CardDT.Columns.Count; j++)
                {
                    Card[j] = CardDT.Rows[i][j].ToString();
                }
            }
            return Card;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchResultsView.Rows.Clear();
            for (int i = 0; i < CardName.Count; i++)
            {
                if (NameCheck.Checked == true && ExpanCheck.Checked == false)
                {
                    if (CardName[i].IndexOf(CardSearchBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [" + CardExpansion[i] + "]");
                    }
                }
                if (NameCheck.Checked == false && ExpanCheck.Checked == true)
                {
                    if (CardExpansion[i].IndexOf(ExpansionBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [" + CardExpansion[i] + "]");
                    }
                }
                if (NameCheck.Checked == true && ExpanCheck.Checked == true)
                {
                    if (CardName[i].IndexOf(CardSearchBox.Text, StringComparison.OrdinalIgnoreCase) != -1 && CardExpansion[i].IndexOf(ExpansionBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [" + CardExpansion[i] + "]");
                    }
                }
            }
        }
    }
}
