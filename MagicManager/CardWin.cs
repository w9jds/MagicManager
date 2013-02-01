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
        public CardWin(int multiverseid)
        {
            int CardMultiverseID = 0;
            string[] Card = new string[10];

            InitializeComponent();
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.DatabaseLocation);
            DBCon.Open();

            OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT * FROM Cards WHERE MultiverseID = '" + multiverseid + "'", DBCon);
            DataSet CardDS = new DataSet();
            CardDA.Fill(CardDS);
            DataTable CardDT = CardDS.Tables[0];
            DBCon.Close();

            for (int i = 0; i < CardDT.Rows.Count; i++)
            {
                CardMultiverseID = Convert.ToInt32(CardDT.Rows[i]["MultiverseID"].ToString());
                for (int j = 0; j < CardDT.Columns.Count; j++)
                {
                    Card[j] = CardDT.Rows[i][j].ToString();
                }
            }
            
            CardName.Text = Card[1];
            if (Card[2] != "")
                ConvMana.Text = "Converted Mana Cost: " + Card[2];
            else
                ConvMana.Text = "";

            CardType.Text = Card[3];

            if (Card[5] != "" || Card[6] != "")
                PowerToughness.Text = "Power: " + Card[5] + "\tToughness: " + Card[6];
            else
                PowerToughness.Text = "";
            Expansion.Text = Card[7];
            Rarity.Text = Card[8];
            CardPic.Load(Card[9]);

        }
    }
}
