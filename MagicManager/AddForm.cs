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
        private string CName = null;
        private string CExpansion = null;
        private int multiverseID = 0;

        public AddForm(int multiverseid, Form MainWinIn)
        {
            MainWin = MainWinIn as MainWindow;
            InitializeComponent();
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.DatabaseLocation);
            DBCon.Open();

            OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT Name, Expansion FROM Cards WHERE MultiverseID = '" + multiverseid + "'", DBCon);
            DataSet CardDS = new DataSet();
            CardDA.Fill(CardDS);
            DataTable CardDT = CardDS.Tables[0];
            DBCon.Close();

            multiverseID = multiverseid;
            CName = CardDT.Rows[0]["Name"].ToString();
            CExpansion = CardDT.Rows[0]["Expansion"].ToString();
            CardName.Text = CName;
            CardExpansion.Text = CExpansion;
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

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (FoilAmount.Visible == true)
            {
                int stdAmount = Convert.ToInt32(NormMulti.Text) - Convert.ToInt32(FoilAmount.Text);
                int FAmount = Convert.ToInt32(FoilAmount.Text);
                MainWin.MyCards.Rows.Add(multiverseID, CName, CExpansion, stdAmount, FAmount);
            }
            else
                MainWin.MyCards.Rows.Add(multiverseID, CName, CExpansion, Convert.ToInt32(NormMulti.Text), 0);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
