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
    public partial class WantToRemove : Form
    {
        MainWindow MainWin = new MainWindow();
        string MultiverseID;

        public WantToRemove(string Name, string multiverseID, Form mainwinin)
        {
            InitializeComponent();
            this.TopMost = true;
            MultiverseID = multiverseID;
            MainWin = mainwinin as MainWindow;
            Ask.Text = "Are you sure you want to remove " + Name + " from your list of owned cards?";

        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveCard_DoWork(object sender, DoWorkEventArgs e)
        {
            OleDbConnection DBCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Settings.Default.OwnedDatabase);
            DBCon.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = DBCon;
            cmd.CommandText = "Delete From MyCards Where MultiverseID = '" + MultiverseID + "'";
            cmd.ExecuteNonQuery();
            DBCon.Close();

            MainWin.updateODB();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            RemoveCard.RunWorkerAsync();
            this.Close();
        }
    }
}
