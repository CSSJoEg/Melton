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
        public EndMenu(string Labeltext)
        {
            InitializeComponent();
            ce_Label1.Parent = pictureBox1;
            ce_Label1.Text = Labeltext;
            restart_button.Parent = pictureBox1;
            exit_button.Parent = pictureBox1;
            game.Hide();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            game.Close();
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
