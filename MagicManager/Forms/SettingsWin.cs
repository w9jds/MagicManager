using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicManager
{
    public partial class SettingsWin : Form
    {
        MainWindow MainWin;

        public SettingsWin(Form MainWinIn)
        {
            MainWin = MainWinIn as MainWindow;
            InitializeComponent();
            DatabasePath.Text = Properties.Settings.Default.DatabaseLocation;
            MyDBPath.Text = Properties.Settings.Default.OwnedDatabase;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool updateDB = false;
            bool updateOwnedDB = false;

            if (Properties.Settings.Default.DatabaseLocation != DatabasePath.Text)
            {
                Properties.Settings.Default.DatabaseLocation = DatabasePath.Text;
                updateDB = true;
            }
            if (Properties.Settings.Default.OwnedDatabase != MyDBPath.Text)
            {
                Properties.Settings.Default.OwnedDatabase = MyDBPath.Text;
                updateOwnedDB = true;
            }
            
            Properties.Settings.Default.Save();
            
            if (updateDB == true)
                MainWin.updateDB();
            if (updateOwnedDB == true)
                MainWin.updateODB();

            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if ((OpenFileDialog.CheckFileExists == true) && (OpenFileDialog.CheckPathExists == true))
                DatabasePath.Text = OpenFileDialog.FileName;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OwnedDatabase == "" || System.IO.File.Exists(Properties.Settings.Default.OwnedDatabase) == false)
            {
                MagicManager.Forms.WantNewDBForm Ask = new MagicManager.Forms.WantNewDBForm(this);
                Ask.Show();
            }
            this.Close();
        }

        private void SearchButton1_Click(object sender, EventArgs e)
        {
            OpenMyFileDialog.ShowDialog();
        }

        private void OpenMyFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if ((OpenMyFileDialog.CheckFileExists == true) && (OpenMyFileDialog.CheckPathExists == true))
                MyDBPath.Text = OpenMyFileDialog.FileName;
        }
    }
}
