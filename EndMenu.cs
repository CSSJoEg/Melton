using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Melton
{
    public partial class EndMenu : Form
    {
        Game game = (Game)Application.OpenForms["game"];
        BoardUI board;
        public EndMenu()
        {
            InitializeComponent();
            

            ce_Label1.Parent = pictureBox1;
            ce_Label1.Parent = pictureBox1;

            if (board.EvilBoss.Health <= 0)
            {
                ce_Label1.Text = "You Won";
            }
            else if (board.Krieger.Health <= 0 && board.Jaeger.Health <= 0 && board.Magier.Health <= 0 && board.Schamane.Health <= 0)
            {
                ce_Label1.Text = "You Lost";
            }
            game.Hide();
        }
    }
}
