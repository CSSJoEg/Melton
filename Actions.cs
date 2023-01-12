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
        bool warriormove;
        bool huntermove;
        bool magemove;
        bool shamanmove;
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
        public bool Warriormove
        {
            get { return warriormove; }
            set { warriormove = value; }
        }
        public bool Huntermove
        {
            get { return huntermove; }
            set { huntermove = value; }
        }
        public bool Magemove
        {
            get { return magemove; }
            set { magemove = value; }
        }
        public bool Shamanmove
        {
            get { return shamanmove; }
            set { shamanmove = value; }
        }
        private void Attack_button_Click(object sender, EventArgs e)
        {
            if (player is Warrior && Warriormove == false)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 8) == board.EvilBoss.Position || (player.Position - 8) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position)
                {
                    player.DoAttack(board.EvilBoss);
                    Fehler_label.Text = "Krieger hat angegriffen";
                    Warriormove = true;
                }
                else
                {
                    Fehler_label.Text = "SPIELER IST NICHT IN REICHWEITE";
                }
            }
            else if (Warriormove == true)
            {
                Fehler_label.Text =  "Krieger hat kein Zug mehr!";
            }
            if (player is Mage || player is Shaman)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position || (player.Position + 11) == board.EvilBoss.Position || (player.Position - 11) == board.EvilBoss.Position || (player.Position + 16) == board.EvilBoss.Position || (player.Position - 16) == board.EvilBoss.Position || (player.Position + 17) == board.EvilBoss.Position || (player.Position - 17) == board.EvilBoss.Position || (player.Position + 18) == board.EvilBoss.Position || (player.Position - 18) == board.EvilBoss.Position || (player.Position + 19) == board.EvilBoss.Position || (player.Position - 19) == board.EvilBoss.Position || (player.Position + 20) == board.EvilBoss.Position || (player.Position - 20) == board.EvilBoss.Position)
                {
                    player.DoAttack(board.EvilBoss);
                    if (player is Mage && Magemove == false)
                    {
                        Fehler_label.Text = "Magier hat angegriffen";
                        Magemove = true;
                    }
                    else if (Magemove == true)
                    {
                        Fehler_label.Text = "Magier hat kein Zug mehr!";
                    }
                    if (player is Shaman && Shamanmove == false)
                    {
                        Fehler_label.Text = "Schamane hat angegriffen";
                        Shamanmove = true;
                    }
                    else if (Shamanmove == true)
                    {
                        Fehler_label.Text = "Schamane hat kein Zug mehr!";
                    }

                }
                else
                {
                    Fehler_label.Text = "SPIELER IST NICHT IN REICHWEITE";
                }
                
            }
            if (player is Hunter && Huntermove == false)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 3) == board.EvilBoss.Position || (player.Position - 3) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 8) == board.EvilBoss.Position || (player.Position - 8) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position || (player.Position + 11) == board.EvilBoss.Position || (player.Position - 11) == board.EvilBoss.Position || (player.Position + 12) == board.EvilBoss.Position || (player.Position - 12) == board.EvilBoss.Position || (player.Position + 15) == board.EvilBoss.Position || (player.Position - 15) == board.EvilBoss.Position || (player.Position + 16) == board.EvilBoss.Position || (player.Position - 16) == board.EvilBoss.Position || (player.Position + 17) == board.EvilBoss.Position || (player.Position - 17) == board.EvilBoss.Position || (player.Position + 18) == board.EvilBoss.Position || (player.Position - 18) == board.EvilBoss.Position || (player.Position + 19) == board.EvilBoss.Position || (player.Position - 19) == board.EvilBoss.Position || (player.Position + 20) == board.EvilBoss.Position || (player.Position - 20) == board.EvilBoss.Position || (player.Position + 21) == board.EvilBoss.Position || (player.Position - 21) == board.EvilBoss.Position || (player.Position + 24) == board.EvilBoss.Position || (player.Position - 24) == board.EvilBoss.Position || (player.Position + 25) == board.EvilBoss.Position || (player.Position - 25) == board.EvilBoss.Position || (player.Position + 26) == board.EvilBoss.Position || (player.Position - 26) == board.EvilBoss.Position || (player.Position + 27) == board.EvilBoss.Position || (player.Position - 27) == board.EvilBoss.Position || (player.Position + 28) == board.EvilBoss.Position || (player.Position - 28) == board.EvilBoss.Position || (player.Position + 29) == board.EvilBoss.Position || (player.Position - 29) == board.EvilBoss.Position || (player.Position + 30) == board.EvilBoss.Position || (player.Position - 30) == board.EvilBoss.Position)
                {
                    player.DoAttack(board.EvilBoss);
                    Fehler_label.Text = "Jäger hat angegriffen";
                    Huntermove = true;
                }
                else
                {
                    Fehler_label.Text = "SPIELER IST NICHT IN REICHWEITE";
                }
            }
            else if(Huntermove == true)
            {
                Fehler_label.Text = "Jäger hat kein Zug mehr!";
            }
        }
        private void Ability_Button_Click(object sender, EventArgs e)
        {
            if (player is Warrior)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position || (player.Position + 11) == board.EvilBoss.Position || (player.Position - 11) == board.EvilBoss.Position || (player.Position + 16) == board.EvilBoss.Position || (player.Position - 16) == board.EvilBoss.Position || (player.Position + 17) == board.EvilBoss.Position || (player.Position - 17) == board.EvilBoss.Position || (player.Position + 18) == board.EvilBoss.Position || (player.Position - 18) == board.EvilBoss.Position || (player.Position + 19) == board.EvilBoss.Position || (player.Position - 19) == board.EvilBoss.Position || (player.Position + 20) == board.EvilBoss.Position || (player.Position - 20) == board.EvilBoss.Position)
                {
                    board.Krieger.Charge(board.EvilBoss);
                    board.Krieger.Position = board.EvilBoss.Position + 9;
                    Warriormove = true;
                }
            }
            if (player is Mage)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position || (player.Position + 11) == board.EvilBoss.Position || (player.Position - 11) == board.EvilBoss.Position || (player.Position + 16) == board.EvilBoss.Position || (player.Position - 16) == board.EvilBoss.Position || (player.Position + 17) == board.EvilBoss.Position || (player.Position - 17) == board.EvilBoss.Position || (player.Position + 18) == board.EvilBoss.Position || (player.Position - 18) == board.EvilBoss.Position || (player.Position + 19) == board.EvilBoss.Position || (player.Position - 19) == board.EvilBoss.Position || (player.Position + 20) == board.EvilBoss.Position || (player.Position - 20) == board.EvilBoss.Position)
                {
                    board.Magier.CastFireball(board.EvilBoss);
                    Magemove = true;
                }
            }
            if (player is Hunter)
            {
                if ((player.Position + 1) == board.EvilBoss.Position || (player.Position - 1) == board.EvilBoss.Position || (player.Position + 2) == board.EvilBoss.Position || (player.Position - 2) == board.EvilBoss.Position || (player.Position + 7) == board.EvilBoss.Position || (player.Position - 7) == board.EvilBoss.Position || (player.Position + 9) == board.EvilBoss.Position || (player.Position - 9) == board.EvilBoss.Position || (player.Position + 10) == board.EvilBoss.Position || (player.Position - 10) == board.EvilBoss.Position || (player.Position + 11) == board.EvilBoss.Position || (player.Position - 11) == board.EvilBoss.Position || (player.Position + 16) == board.EvilBoss.Position || (player.Position - 16) == board.EvilBoss.Position || (player.Position + 17) == board.EvilBoss.Position || (player.Position - 17) == board.EvilBoss.Position || (player.Position + 18) == board.EvilBoss.Position || (player.Position - 18) == board.EvilBoss.Position || (player.Position + 19) == board.EvilBoss.Position || (player.Position - 19) == board.EvilBoss.Position || (player.Position + 20) == board.EvilBoss.Position || (player.Position - 20) == board.EvilBoss.Position)
                {
                    board.Jaeger.RapidArrow(board.EvilBoss);
                    Huntermove = true;
                }
            }
            if (player is Shaman)
            {
                board.Schamane.DoHeal(board.EvilBoss);
            } 
        }
        private void Ability_Button_MouseHover(object sender, EventArgs e)
        {
            if(player is Warrior)
            {
                toolTip1.Show("Hallo Krieger", Ability_Button);
            }
            if (player is Hunter)
            {
                toolTip1.Show("Hallo Jaeger", Ability_Button);
            }
            if(player is Hunter)
            {
                toolTip1.Show("Hallo Magier", Ability_Button);
            }
            if (player is Shaman)
            {
                toolTip1.Show("Hallo Schamane", Ability_Button);
            }
        }
        private void Skip_Button_Click(object sender, EventArgs e)
        {
            player.Health += 10;
        }

        private void Skip_Button_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Regeneriert eine kleine Menge Leben, aber du setzt einen Zug aus.", Skip_Button);
        }
    }
}
