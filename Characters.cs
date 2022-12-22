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
    public partial class Characters : Form
    {
        public Form parent { get; set; }
        public Characters(Form mdiParent)
        {
            InitializeComponent();
            parent = mdiParent;
        }
    }
}
