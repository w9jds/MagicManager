using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicManager
{
    public partial class MainWindow : Form
    {
        public List<int> CardMultiverseID = new List<int>();
        public List<string> CardName = new List<string>();
        public List<string> CardExpansion = new List<string>();
        public List<string> CardImgURL = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
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
            catch(Exception){  }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWin setSettings = new SettingsWin();
            setSettings.Show();
        }

        private void CardSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchResultsView.Rows.Clear();
            for (int i = 0; i < CardName.Count; i++)
            {
                if (CardName[i].IndexOf(CardSearchBox.Text, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    SearchResultsView.Rows.Add(CardMultiverseID[i], CardName[i] + " [" + CardExpansion[i] + "]");
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void SearchResultsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int multiverseid = Convert.ToInt32(SearchResultsView.Rows[e.RowIndex].Cells["MultiverseID"].Value.ToString());
            CardWin Card = new CardWin(multiverseid);
            Card.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
