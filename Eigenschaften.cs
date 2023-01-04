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
                classpicture.BackgroundImage = Properties.Resources.warriorbackground;
                class_label.Text = "Krieger";
                HP_label.Text = Convert.ToString(board.Krieger.Health);
                MP_label.Text = "0";
                ATK_label.Text = Convert.ToString(board.Krieger.Attack);
                special_label.Text = Convert.ToString(board.Krieger.DodgeValue);
            }
            if (board.positionname.Contains("Mage"))
            {
                classpicture.BackgroundImage = Properties.Resources.magebackground;
                class_label.Text = "Magier";
                HP_label.Text = Convert.ToString(board.Magier.Health);
                MP_label.Text = Convert.ToString(board.Magier.Mana);
                ATK_label.Text = Convert.ToString(board.Magier.Attack);
                special_label.Text = Convert.ToString(board.Magier.AttackSpeed);
            }
            if (board.positionname.Contains("Hunter"))
            {
                classpicture.BackgroundImage = Properties.Resources.hunterbackground;
                class_label.Text = "Jäger";
                HP_label.Text = Convert.ToString(board.Jaeger.Health);
                MP_label.Text = Convert.ToString(board.Jaeger.Energy);
                ATK_label.Text = Convert.ToString(board.Jaeger.Attack);
                special_label.Text = Convert.ToString(board.Jaeger.AttackSpeed);
            }
            if (board.positionname.Contains("Shaman"))
            {
                classpicture.BackgroundImage = Properties.Resources.druidbackground;
                class_label.Text = "Schamane";
                HP_label.Text = Convert.ToString(board.Schamane.Health);
                MP_label.Text = Convert.ToString(board.Schamane.Mana);
                ATK_label.Text = Convert.ToString(board.Schamane.Attack);
                special_label.Text = Convert.ToString(board.Schamane.AttackSpeed);
            }
            classpicture.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
