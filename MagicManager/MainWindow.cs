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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWin setSettings = new SettingsWin();
            setSettings.Show();
        }
    }
}
