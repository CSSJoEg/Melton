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
        string Label;
        Game game = (Game)Application.OpenForms["game"];
        public string label
        {
            get { return Label; }
            set { Label = value; }
        }
        public EndMenu()
        {
            InitializeComponent();
            ce_Label1.Text = label;
            ce_Label1.Parent = pictureBox1;
            ce_Label1.Parent = pictureBox1;
            game.Hide();
        }
    }
}
