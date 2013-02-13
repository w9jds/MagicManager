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
    public partial class EditOwnedCardFrm : Form
    {
        MainWindow MainWin;
        string MultiverseID;
        string stdAmount;
        string foilAmount;
        
        public EditOwnedCardFrm(string multiverseid, string name, string expansion, string stdAmount, string foilAmount, Form mainwinin)
        {
            MainWin = mainwinin as MainWindow;
            MultiverseID = multiverseid;
            InitializeComponent();
            this.TopMost = true;
            CardName.Text = name;
            CardExpansion.Text = expansion;
            StdAmount.Text = stdAmount;
            FoilAmount.Text = foilAmount;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            stdAmount = StdAmount.Text;
            foilAmount = FoilAmount.Text;
            EditCardBGW.RunWorkerAsync();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCardBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.OwnedDatabase);
            OleDbCommand cmd = new OleDbCommand("Update MyCards set stdAmount = '" + stdAmount + "', foilAmount = '" + foilAmount + "' where MultiverseID = '" + MultiverseID + "'", DBCon);
            DBCon.Open();
            cmd.ExecuteNonQuery();
            DBCon.Close();
            MainWin.updateODB();
        }
    }
}
