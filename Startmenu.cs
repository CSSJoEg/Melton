using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melton
{
    public partial class Startmenu : Form
    {
        BoardUI Board;
        Characters character;
        Settings setting;
        Game game = (Game)Application.OpenForms["game"];

        public Form parent { get; set; }

        public Startmenu(Form mdiParent)
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            parent = mdiParent;
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Board = new BoardUI(parent);
            Board.MdiParent = parent;
            Board.Show();
        }
        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btn_character_Click(object sender, EventArgs e)
        {
            character = new Characters(parent);
            character.MdiParent = parent;
            character.Show();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            setting = new Settings(parent);
            setting.MdiParent = parent;
            setting.Show();
        }
    }
}
