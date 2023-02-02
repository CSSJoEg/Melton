using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Melton
{
    public partial class LoadingScreen : Form
    {
        Game game = (Game)Application.OpenForms["game"];
        public LoadingScreen()
        {
            InitializeComponent();
            
            LoadingLabel.Parent = pictureBox1;
            ce_RingProgressBar1.Parent = pictureBox1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ce_RingProgressBar1.Value += 2;
            if(ce_RingProgressBar1.Value >= 99)
            {
                timer1.Enabled = false;
                this.Close();
                game.Show();
            }
        }
    }
}
