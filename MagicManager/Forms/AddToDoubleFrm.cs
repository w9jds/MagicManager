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
    public partial class AddToDoubleFrm : Form
    {
        public AddToDoubleFrm(string[] DoubleCard, int stdAmount, int foilAmount)
        {
            InitializeComponent();
            YouHaveDouble.Text = "You already have the card " + DoubleCard[1] + " from expansion " + DoubleCard[2] + " listed in your owned cards. It currently states you have " + DoubleCard[3] + " standard versions of the card, and " + DoubleCard[4] + " foil versions of the card. \nWould you like to add the entered amount to the amount already listed?";
        }
    }
}
