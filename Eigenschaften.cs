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
    public partial class Eigenschaften : Form
    {
        BoardUI board;
        Warrior warrior;
        public Eigenschaften(BoardUI form)
        {
            InitializeComponent();  
            board= form;
        }

        private void Eigenschaften_Load(object sender, EventArgs e)
        {
            if (board.positionname.Contains("Warrior"))
            {
                HP_label.Text = Convert.ToString(warrior.Health);
            }
        }
    }
}
