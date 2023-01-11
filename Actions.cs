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
    public partial class Actions : Form
    {
        BoardUI board;
        MeltonCreature player;
        public Actions(BoardUI form, MeltonCreature belongsTo)
        {
            InitializeComponent();
            board = form;
            player = belongsTo;
            if (player is Boss)
            {
                Attack_button.Enabled = false;
                Ability_Button.Enabled = false;
                Skip_Button.Enabled = false;
                Attack_button.Hide();
                Ability_Button.Hide();
                Skip_Button.Hide();
            }
        }
        private void Attack_button_Click(object sender, EventArgs e)
        {
            
            if (player is Warrior)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 8) == board.EvilBoss.Position || (player.Position - 8) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position)
                {
                    player.DoAttack(board.EvilBoss);
                    Fehler_label.Text = "SPIELER hat angegriffen";
                }
                else
                {
                    Fehler_label.Text = "SPIELER IST NICHT IN REICHWEITE";
                }
            }
            if (player is Mage || player is Shaman)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position || (player.Position + 11) == board.EvilBoss.Position || (player.Position - 11) == board.EvilBoss.Position || (player.Position + 16) == board.EvilBoss.Position || (player.Position - 16) == board.EvilBoss.Position || (player.Position + 17) == board.EvilBoss.Position || (player.Position - 17) == board.EvilBoss.Position || (player.Position + 18) == board.EvilBoss.Position || (player.Position - 18) == board.EvilBoss.Position || (player.Position + 19) == board.EvilBoss.Position || (player.Position - 19) == board.EvilBoss.Position || (player.Position + 20) == board.EvilBoss.Position || (player.Position - 20) == board.EvilBoss.Position)
                {
                    player.DoAttack(board.EvilBoss);
                    Fehler_label.Text = "SPIELER hat angegriffen";
                }
                else
                {
                    Fehler_label.Text = "SPIELER IST NICHT IN REICHWEITE";
                }
            }
            if (player is Hunter)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 3) == board.EvilBoss.Position || (player.Position - 3) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 8) == board.EvilBoss.Position || (player.Position - 8) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position || (player.Position + 11) == board.EvilBoss.Position || (player.Position - 11) == board.EvilBoss.Position || (player.Position + 12) == board.EvilBoss.Position || (player.Position - 12) == board.EvilBoss.Position || (player.Position + 15) == board.EvilBoss.Position || (player.Position - 15) == board.EvilBoss.Position || (player.Position + 16) == board.EvilBoss.Position || (player.Position - 16) == board.EvilBoss.Position || (player.Position + 17) == board.EvilBoss.Position || (player.Position - 17) == board.EvilBoss.Position || (player.Position + 18) == board.EvilBoss.Position || (player.Position - 18) == board.EvilBoss.Position || (player.Position + 19) == board.EvilBoss.Position || (player.Position - 19) == board.EvilBoss.Position || (player.Position + 20) == board.EvilBoss.Position || (player.Position - 20) == board.EvilBoss.Position || (player.Position + 21) == board.EvilBoss.Position || (player.Position - 21) == board.EvilBoss.Position || (player.Position + 24) == board.EvilBoss.Position || (player.Position - 24) == board.EvilBoss.Position || (player.Position + 25) == board.EvilBoss.Position || (player.Position - 25) == board.EvilBoss.Position || (player.Position + 26) == board.EvilBoss.Position || (player.Position - 26) == board.EvilBoss.Position || (player.Position + 27) == board.EvilBoss.Position || (player.Position - 27) == board.EvilBoss.Position || (player.Position + 28) == board.EvilBoss.Position || (player.Position - 28) == board.EvilBoss.Position || (player.Position + 29) == board.EvilBoss.Position || (player.Position - 29) == board.EvilBoss.Position || (player.Position + 30) == board.EvilBoss.Position || (player.Position - 30) == board.EvilBoss.Position)
                {
                    player.DoAttack(board.EvilBoss);
                    Fehler_label.Text = "SPIELER hat angegriffen";
                }
                else
                {
                    Fehler_label.Text = "SPIELER IST NICHT IN REICHWEITE";
                }
            }   
        }
        private void Ability_Button_Click(object sender, EventArgs e)
        {

        }
        private void Ability_Button_MouseHover(object sender, EventArgs e)
        {
            if (player is Warrior)
            {
                toolTip1.Show("Hallo Krieger", Attack_button);
            }
            if (player is Mage)
            {
                toolTip1.Show("Hallo Magier", Attack_button);
            }
            if (player is Hunter)
            {
                toolTip1.Show("Hallo Jaeger", Attack_button);
            }
            if (player is Shaman)
            {
                toolTip1.Show("Hallo Schamane", Attack_button);
            }

        }

        private void Skip_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Skip_Button_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Regeneriert eine kleine Menge Leben, aber du setzt einen Zug aus.", Skip_Button);
        }
    }
}
