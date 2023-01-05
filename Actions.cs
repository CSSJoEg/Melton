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
    public partial class Actions : Form
    {
        BoardUI board;
        MeltonCreature player;
        Random rnd = new Random();
        public Actions(BoardUI form, MeltonCreature belongsTo)
        {
            InitializeComponent();
            board = form;
            player = belongsTo;
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
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 8) == board.EvilBoss.Position || (player.Position - 8) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position)
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
        }
        private void Ability_Button_Click(object sender, EventArgs e)
        {

        }

        private void Attack_button_MouseHover(object sender, EventArgs e)
        {
            if(player is Warrior)
            {
                toolTip1.Show("Hallo", Attack_button);
            }            
        }
    }
}
