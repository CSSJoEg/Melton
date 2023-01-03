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
        Warrior warrior = new Warrior();
        public Eigenschaften(BoardUI form)
        {
            InitializeComponent();  
            board= form;
        }

        private void Eigenschaften_Load(object sender, EventArgs e)
        {
            if (board.positionname.Contains("Warrior"))
            {
                classpicture.BackgroundImage = Properties.Resources.Warrior;
                classpicture.BackgroundImageLayout = ImageLayout.Stretch;
                class_label.Text = "Krieger";
                HP_label.Text = Convert.ToString(board.Krieger.Health);
                MP_label.Text = "0";
                ATK_label.Text = Convert.ToString(board.Krieger.Attack);
                special_label.Text = Convert.ToString(board.Krieger.DodgeValue);
            }
            if(board.positionname.Contains("Hunter"))
            {
                classpicture.BackgroundImage = Properties.Resources.Hunter;
                HP_label.Text = Convert.ToString(board.Jaeger.Health);
                MP_label.Text = Convert.ToString(board.Jaeger.Energy);
                ATK_label.Text = Convert.ToString(board.Jaeger.Attack);
                special_label.Text = Convert.ToString(board.Jaeger.AttackSpeed);
            }
        }
    }
}
