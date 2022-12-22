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
        Eigenschaften eigenschaften;
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
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor= Color.Black;
                btn.Size = new Size(80, 80);
                btn.ForeColor= Color.Black;
                
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
            eigenschaften.Location = new Point(this.Location.X + 796, this.Location.Y);
        }

        public void BoardUI_LocationChanged(object sender, EventArgs e)
        {
            if (eigenschaften != null)
            {
                eigenschaften.Location = new Point(this.Location.X + 796, this.Location.Y);
            }
        }
    }
}
