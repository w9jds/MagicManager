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

                OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT MultiverseID, Name, Expansion, ImgURL FROM Cards", DBCon);
                DataSet CardDS = new DataSet();
                CardDA.Fill(CardDS);
                DataTable CardDT = CardDS.Tables[0];
                DBCon.Close();

                for (int i = 0; i < CardDT.Rows.Count; i++)
                {
                    CardMultiverseID.Add(Convert.ToInt32(CardDT.Rows[i]["MultiverseID"].ToString()));
                    CardName.Add(CardDT.Rows[i]["Name"].ToString());
                    CardExpansion.Add(CardDT.Rows[i]["Expansion"].ToString());
                    CardImgURL.Add(CardDT.Rows[i]["ImgURL"].ToString());
                }

            }
            catch(Exception){  }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWin setSettings = new SettingsWin();
            setSettings.Show();
        }

        private void CardSearch_TextUpdate(object sender, EventArgs e)
        {
            CardSearch.Items.Clear();
            for (int i = 0; i < CardName.Count; i++)
            {
                if (CardName[i].IndexOf(CardSearch.Text) == 0)
                {
                    CardSearch.Items.Add(CardName[i] + " [ " + CardExpansion[i] + " ]");
                }
            }
        }
    }
}
