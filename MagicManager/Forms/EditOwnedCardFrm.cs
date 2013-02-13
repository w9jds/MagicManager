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
    public partial class EditOwnedCardFrm : Form
    {
        MainWindow MainWin;
        string MultiverseID;
        
        public EditOwnedCardFrm(string multiverseid, string name, string expansion, string stdAmount, string foilAmount, Form mainwinin)
        {
            MainWin = mainwinin as MainWindow;
            MultiverseID = multiverseid;
            InitializeComponent();
            CardName.Text = name;
            CardExpansion.Text = expansion;

        }
    }
}
