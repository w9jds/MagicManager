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
        private MainWindow MainWin;

        public CardWin(int multiverseid, Form MainWinIn)
        {
            
            string[] Card = new string[10];
            MainWin = MainWinIn as MainWindow;
            InitializeComponent();
            Card = MainWin.GetCardInfo(multiverseid);

            CardMultiverseID = Convert.ToInt32(Card[0]);
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

        private void ViewLegalityBtn_Click(object sender, EventArgs e)
        {
            LegalityWin CardsLegality = new LegalityWin(CardMultiverseID);
            CardsLegality.Show();
        }

        private void ViewCostBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
