using Melton.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melton
{
    public partial class BoardUI : Form
    {
        Eigenschaften eigenschaften = (Eigenschaften)Application.OpenForms["eigenschaften"];
        public Form parent { get; set; }
        public BoardUI(Form mdiParent)
        {
            InitializeComponent();
            ButtonArray();
            Bitmap background = new Bitmap(@"C:\Users\ajira\source\repos\Melton\Melton\Resources\background.png");
            flowLayoutPanel1.BackgroundImage = background;
            parent = mdiParent;
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void ButtonArray()
        {
            for (int i = 0; i < 81; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 90);
                btn.Text = i.ToString();
                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            Button btnPos = (Button)sender;
            eigenschaften = new Eigenschaften();
            eigenschaften.MdiParent = parent;
            eigenschaften.Show();
            eigenschaften.Location = new Point(this.Location.X + 655, this.Location.Y);
        }

        public void BoardUI_LocationChanged(object sender, EventArgs e)
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
            if (eigenschaften != null)
            {
                eigenschaften.Location = new Point(this.Location.X + 655, this.Location.Y);
            }
        }
    }
}
