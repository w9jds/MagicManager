using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicManager.Forms
{
    public partial class WantNewDBForm : Form
    {
        MainWindow MainWin;

        public WantNewDBForm(Form MainWinIn)
        {
            MainWin = MainWinIn as MainWindow;

            InitializeComponent();
            this.TopMost = true;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            MakeOwnedDBbgw.RunWorkerAsync();
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakeOwnedDBbgw_DoWork(object sender, DoWorkEventArgs e)
        {
            string DocLocation = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Magic Manager\\";
            if (!System.IO.Directory.Exists(DocLocation))
                System.IO.Directory.CreateDirectory(DocLocation);

            DocLocation += "MyCards.mmodb";

            ADOX.Catalog CreateDB = new ADOX.Catalog();
            CreateDB.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + DocLocation + "; Jet OLEDB:Engine Type=5");

            ADOX.Table CardTable = new ADOX.Table();
            CardTable.Name = "MyCards";
            CardTable.Columns.Append("MultiverseID");
            CardTable.Columns.Append("Name");
            CardTable.Columns.Append("Expansion");
            CardTable.Columns.Append("stdAmount");
            CardTable.Columns.Append("foilAmount");
            CreateDB.Tables.Append(CardTable);

            OleDbConnection DBcon = CreateDB.ActiveConnection as OleDbConnection;
            if (DBcon != null)
                DBcon.Close();

            Marshal.ReleaseComObject(CreateDB.ActiveConnection);
            Marshal.ReleaseComObject(CreateDB);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Properties.Settings.Default.OwnedDatabase = DocLocation;
            Properties.Settings.Default.Save();
        }
    }
}
