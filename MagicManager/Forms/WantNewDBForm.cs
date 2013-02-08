using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.Focus();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {

        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
