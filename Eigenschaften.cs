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
        MeltonCreature creature;
        public Eigenschaften(BoardUI form, MeltonCreature belongsTo)
        {
            InitializeComponent();  
            board = form;
            creature = belongsTo;
        }
        private void Eigenschaften_Load(object sender, EventArgs e)
        {
            if (this.creature is Boss)
            {
                classpicture.BackgroundImage = Properties.Resources.bossbackground;
                class_label.Text = "Sensenmann";
                MP_label.Text = Convert.ToString(board.EvilBoss.Rage);
                special_label.Text = Convert.ToString(board.EvilBoss.AttackSpeed);
            }
            if (this.creature is Warrior)
            {
                classpicture.BackgroundImage = Properties.Resources.warriorbackground;
                class_label.Text = "Krieger";
                MP_label.Text = "0";
                special_label.Text = Convert.ToString(1);
            }
            if (this.creature is Hunter)
            {
                classpicture.BackgroundImage = Properties.Resources.hunterbackground;
                class_label.Text = "Jäger";
                MP_label.Text = Convert.ToString(board.Jaeger.Energy);
                special_label.Text = Convert.ToString(board.Jaeger.AttackSpeed);
            }
            if (this.creature is Mage)
            {
                classpicture.BackgroundImage = Properties.Resources.magebackground;
                class_label.Text = "Magier";
                MP_label.Text = Convert.ToString(board.Magier.Mana);
                special_label.Text = Convert.ToString(board.Magier.AttackSpeed);
            }          
            if (this.creature is Shaman)
            {
                classpicture.BackgroundImage = Properties.Resources.druidbackground;
                class_label.Text = "Schamane";
                MP_label.Text = Convert.ToString(board.Schamane.Mana);
                special_label.Text = Convert.ToString(board.Schamane.AttackSpeed);
            }
            HP_label.Text = Convert.ToString(creature.Health);
            ATK_label.Text = Convert.ToString(creature.Attack);
            classpicture.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
