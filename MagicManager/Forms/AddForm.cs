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
        private string[] Card = new string[3];
        private string[] DoubleCard = new string[5];
        private int multiverseID = 0;
        private int foilAmount = 0;
        private int stdAmount = 0;
        

        public AddForm(int multiverseid, Form MainWinIn)
        {
            MainWin = MainWinIn as MainWindow;
            InitializeComponent();
            multiverseID = multiverseid;
            CardInfoBGW.RunWorkerAsync();
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
                stdAmount = Convert.ToInt32(NormMulti.Text) - Convert.ToInt32(FoilAmount.Text);
                foilAmount = Convert.ToInt32(FoilAmount.Text);
            }
            else
                stdAmount = Convert.ToInt32(NormMulti.Text);

            bool Double = checkIfExists();
            if (Double == false)
                AddToOwnedBGW.RunWorkerAsync();
            else 
            {
                AddToDoubleFrm want = new AddToDoubleFrm(DoubleCard, stdAmount, foilAmount, MainWin);
                want.Show();
            }
            this.Close();
        }

        private bool checkIfExists()
        {
               
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.OwnedDatabase);
            DBCon.Open();

            OleDbDataAdapter CardDA = new OleDbDataAdapter("Select * From MyCards Where MultiverseID = '" + multiverseID + "'", DBCon);
            DataSet CardDS = new DataSet();
            CardDA.Fill(CardDS);
            DataTable CardDT = CardDS.Tables[0];
            DBCon.Close();

            if (CardDT.Rows.Count != 0)
            {
                for (int i = 0; i < CardDT.Rows.Count; i++)
                {
                    for (int j = 0; j < CardDT.Columns.Count; j++)
                    {
                        DoubleCard[j] = CardDT.Rows[i][j].ToString();
                    }
                }
                
                return true;
            }
            else
                return false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CardInfoBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.DatabaseLocation);
            DBCon.Open();

            OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT MultiverseID, Name, Expansion FROM Cards WHERE MultiverseID = '" + multiverseID + "'", DBCon);
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

            CardName.Invoke((MethodInvoker)delegate { CardName.Text = Card[1]; });
            CardExpansion.Invoke((MethodInvoker)delegate { CardExpansion.Text = Card[2]; });
        }



        private void AddToOwnedBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            
            OleDbConnection DBcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.OwnedDatabase);
            DBcon.Open();
            OleDbCommand DBcmd = new OleDbCommand();
            DBcmd.Connection = DBcon;
            DBcmd.CommandText = "INSERT INTO MyCards([MultiverseID], [Name], [Expansion], [stdAmount], [foilAmount]) Values ('" + Card[0] + "','" + Card[1] + "','" + Card[2] + "','" + stdAmount + "','" + foilAmount + "')";
            DBcmd.ExecuteNonQuery();
            DBcon.Close();
           
            MainWin.updateODB();
        }
    }
}
