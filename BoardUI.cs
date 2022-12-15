using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melton
{
    public partial class BoardUI : Form
    {
        public BoardUI()
        {
            InitializeComponent();
            ButtonArray();
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
            if (btnPos.Tag == "")
            {

            }
        }
    }
}
