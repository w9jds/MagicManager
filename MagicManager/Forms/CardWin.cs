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
    public partial class CardWin : Form
    {
        private int CardMultiverseID = 0;
        private string[] Card = new string[10];

        public CardWin(int multiverseid)
        {
            CardMultiverseID = multiverseid;
            InitializeComponent();
            CardInfoBGW.RunWorkerAsync();
        }

        private void ViewLegalityBtn_Click(object sender, EventArgs e)
        {
            LegalityWin CardsLegality = new LegalityWin(CardMultiverseID);
            CardsLegality.Show();
        }

        private void ViewCostBtn_Click(object sender, EventArgs e)
        {

        }

        private void CardInfoBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] CardInfo = new string[10];

            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.DatabaseLocation);
            DBCon.Open();

            OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT * FROM Cards WHERE MultiverseID = '" + CardMultiverseID + "'", DBCon);
            DataSet CardDS = new DataSet();
            CardDA.Fill(CardDS);
            DataTable CardDT = CardDS.Tables[0];
            DBCon.Close();

            this.Card = CardInfo;

            for (int i = 0; i < CardDT.Rows.Count; i++)
            {
                for (int j = 0; j < CardDT.Columns.Count; j++)
                {
                    Card[j] = CardDT.Rows[i][j].ToString();
                }
            }

            CardName.Invoke((MethodInvoker)delegate { CardName.Text = Card[1]; });
            
            if (Card[2] != "")
                ConvMana.Invoke((MethodInvoker)delegate {  ConvMana.Text = "Converted Mana Cost: " + Card[2]; });
            else
                ConvMana.Invoke((MethodInvoker)delegate { ConvMana.Text = ""; });

            CardType.Invoke((MethodInvoker)delegate { CardType.Text = Card[3]; });

            if (Card[5] != "" || Card[6] != "")
                PowerToughness.Invoke((MethodInvoker)delegate { PowerToughness.Text = "Power: " + Card[5] + "\tToughness: " + Card[6]; });
            else
                PowerToughness.Invoke((MethodInvoker)delegate { PowerToughness.Text = ""; });

            Expansion.Invoke((MethodInvoker)delegate { Expansion.Text = Card[7]; });
            Rarity.Invoke((MethodInvoker)delegate { Rarity.Text = Card[8]; });
            CardPic.Invoke((MethodInvoker)delegate { CardPic.Load(Card[9]); });
        }
    }
}
