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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Startmenu Menu = new Startmenu(this);
            Menu.MdiParent = this;
            Menu.Show();
        }

 
    }
}
