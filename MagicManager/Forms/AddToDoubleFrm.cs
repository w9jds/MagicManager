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
    public partial class AddToDoubleFrm : Form
    {
        MainWindow MainWin;
        string[] Card;
        int StdAmount, FoilAmount;

        public AddToDoubleFrm(string[] DoubleCard, int stdAmount, int foilAmount, Form mainwinin)
        {
            MainWin = mainwinin as MainWindow;
            Card = DoubleCard;
            StdAmount = stdAmount;
            FoilAmount = foilAmount;
            InitializeComponent();
            YouHaveDouble.Text = "You already have the card " + DoubleCard[1] + " from expansion " + DoubleCard[2] + " listed in your owned cards. It currently states you have " + DoubleCard[3] + " standard versions of the card, and " + DoubleCard[4] + " foil versions of the card. \nWould you like to add the entered amount to the amount already listed?";
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            UpdateOwnedBWG.RunWorkerAsync();
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateOwnedBWG_DoWork(object sender, DoWorkEventArgs e)
        {
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.OwnedDatabase);
            OleDbCommand cmd = new OleDbCommand("Update MyCards set stdAmount = '" + (Convert.ToInt32(Card[3]) + StdAmount).ToString() + "', foilAmount = '" + (Convert.ToInt32(Card[4]) + FoilAmount).ToString() + "' where MultiverseID = '" + Card[0] + "'", DBCon);
            DBCon.Open();
            cmd.ExecuteNonQuery();
            DBCon.Close();

            MainWin.updateODB();
        }
    }
}
