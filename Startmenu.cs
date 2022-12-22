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
        private void Startmenu_LocationChanged(object sender, EventArgs e)
        {
            MdiClient mdiClient = null;
            foreach (Control ctl in MdiParent.Controls)
            {
                mdiClient = ctl as MdiClient;
                if (mdiClient != null)
                    break;
            }
            if (Left < mdiClient.ClientRectangle.Left)
            {
                Left = mdiClient.ClientRectangle.Left;
            }
            if (Top < mdiClient.ClientRectangle.Top)
            {
                Top = mdiClient.ClientRectangle.Top;
            }
            if (Top + Height > mdiClient.ClientRectangle.Height)
            {
                Top = mdiClient.ClientRectangle.Height - Height;
            }  
            if (Left + Width > mdiClient.ClientRectangle.Width)
            {
                Left = mdiClient.ClientRectangle.Width - Width;
            }    
            base.OnMove(e);
        }
    }
}
