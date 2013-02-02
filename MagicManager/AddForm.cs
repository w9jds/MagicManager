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
        public AddForm(int multiverseid)
        {
            InitializeComponent();
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.DatabaseLocation);
            DBCon.Open();

            OleDbDataAdapter CardDA = new OleDbDataAdapter("SELECT Name, Expansion FROM Cards WHERE MultiverseID = '" + multiverseid + "'", DBCon);
            DataSet CardDS = new DataSet();
            CardDA.Fill(CardDS);
            DataTable CardDT = CardDS.Tables[0];
            DBCon.Close();

            CardName.Text = CardDT.Rows[0]["Name"].ToString();
            CardExpansion.Text = CardDT.Rows[0]["Expansion"].ToString();
        }

        private void NormMulti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
