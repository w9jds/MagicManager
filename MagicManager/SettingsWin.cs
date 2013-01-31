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
        public SettingsWin()
        {
            InitializeComponent();
            DatabasePath.Text = Properties.Settings.Default.DatabaseLocation;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DatabaseLocation = DatabasePath.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if ((OpenFileDialog.CheckFileExists == true) && (OpenFileDialog.CheckPathExists == true))
            {
                string database = OpenFileDialog.FileName;
                DatabasePath.Text = database;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
