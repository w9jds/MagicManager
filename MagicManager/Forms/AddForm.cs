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
    public partial class AddForm : Form
    {
        private MainWindow MainWin = null;
        private string[] Card = new string[10];
        private int multiverseID = 0;

        public AddForm(int multiverseid, Form MainWinIn)
        {
            MainWin = MainWinIn as MainWindow;
            InitializeComponent();
            Card = MainWin.GetCardInfo(multiverseid);

            multiverseID = multiverseid;
            CardName.Text = Card[1];
            CardExpansion.Text = Card[7];
        }

        private void NormMulti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FoilAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FoilCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FoilCombo.SelectedIndex == 0)
            {
                AmountFoilLabel.Visible = false;
                FoilAmount.Text = "";
                FoilAmount.Visible = false;
            }
            else if (FoilCombo.SelectedIndex == 1)
            {
                AmountFoilLabel.Visible = true;
                FoilAmount.Text = "";
                FoilAmount.Visible = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (FoilAmount.Visible == true)
            {
                int stdAmount = Convert.ToInt32(NormMulti.Text) - Convert.ToInt32(FoilAmount.Text);
                int FAmount = Convert.ToInt32(FoilAmount.Text);
                MainWin.AddOwnedCard(Card, stdAmount, FAmount);
                //MainWin.MyCards.Rows.Add(multiverseID, CName, CExpansion, stdAmount, FAmount);
            }
            else
                MainWin.AddOwnedCard(Card, Convert.ToInt32(NormMulti.Text), 0);
                //MainWin.MyCards.Rows.Add(multiverseID, CName, CExpansion, Convert.ToInt32(NormMulti.Text), 0);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
