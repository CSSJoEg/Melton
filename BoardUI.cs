using Melton.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melton.Helpers;
using System.CodeDom;
using System.Media;

namespace Melton
{
    public partial class BoardUI : Form
    {
        Game game = (Game)Application.OpenForms["game"];
        Eigenschaften eigenschaften;
        Actions action;
        EndMenu end;
        Button btn = new Button();
        Button btndragclass;
        Button btndropclass;
        Boss evilboss;
        Warrior krieger;
        Hunter hunter;
        Mage magier;
        Shaman schamane;
        List<MeltonCreature> playerlist = new List<MeltonCreature>();
        bool moveOfWarrior = false;
        bool moveOfMage = false;
        bool moveOfHunter = false;
        bool moveOfShaman = false;
        int specialcounter = 0;
        bool bossdeath = false;
        bool warriordeath = false;
        bool magedeath = false;
        bool hunterdeath = false;
        bool shamandeath = false;
        public Form parent { get; set; }
        public bool MoveOfWarrior
        {
            get { return moveOfWarrior; }
            set { moveOfWarrior = value; }
        }
        public bool MoveOfMage
        {
            get { return moveOfMage; }
            set { moveOfMage = value; }
        }
        public bool MoveOfHunter
        {
            get { return moveOfHunter; }
            set { moveOfHunter = value; }
        }
        public bool MoveOfShaman
        {
            get { return moveOfShaman; }
            set { moveOfShaman = value; }
        }
        public Boss EvilBoss
        {
            get { return evilboss; }
            set { evilboss = value; }
        }
        public Warrior Krieger
        {
            get { return krieger; }
            set { krieger = value; }
        }
        public Hunter Jaeger
        {
            get { return hunter; }
            set { hunter = value; }
        }
        public Mage Magier
        {
            get { return magier; }
            set { magier = value; }
        }
        public Shaman Schamane
        {
            get { return schamane; }
            set { schamane = value; }
        }
        public Button Btndragclass
        {
            get { return btndragclass; }
            set { btndragclass = value; }
        }
        public Button Btndropclass
        {
            get { return btndropclass; }
            set { btndropclass = value; }
        }
        public List<MeltonCreature> Playerlist
        {
            get { return playerlist; }
            set { playerlist = value; }
        }
        public BoardUI(Form mdiParent)
        {
            InitializeComponent();
            flowLayoutPanel1.BackgroundImage = Properties.Resources.background;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            parent = mdiParent;
            Boss EvilBoss1 = new Boss()
            {
                Attack = 40,
                AOE = 10,
                AttackSpeed = 4F,
                Health = 250,
                MaxHealth = 500,
                Name = "Boss"
            };
            EvilBoss = EvilBoss1;
            Warrior Krieger1 = new Warrior()
            {
                Attack = 20,
                DodgeValue = 0.2F,
                Health = 100,
                MaxHealth = 100,
                Name = "player.Krieger"
            };
            Krieger = Krieger1;
            Hunter Jaeger1 = new Hunter()
            {
                Attack = 30,
                AttackSpeed = 0.2F,
                Energy = 100,
                Health = 60,
                MaxHealth = 60,
                Name = "player.Jäger"
            };
            Jaeger = Jaeger1;
            Mage Magier1 = new Mage()
            {
                Attack = 50,
                AttackSpeed = 0.6F,
                Mana = 100,
                Health = 60,
                MaxHealth = 60,
                Name = "player.Magier"
            };
            Magier = Magier1;
            Shaman Schamane1 = new Shaman()
            {
                Attack = 10,
                AttackSpeed = 0.4F,
                HealingValue = 20,
                Mana = 100,
                Health = 80,
                MaxHealth = 80,
                Name = "player.Schamane"
            };
            Schamane = Schamane1;
            EvilBoss.Position = 22;
            Krieger.Position = 56;
            Magier.Position = 57;
            Jaeger.Position = 59;
            Schamane.Position = 60;
            List<MeltonCreature> players = new List<MeltonCreature>();

            players.Add(Krieger1);
            players.Add(Jaeger1);
            players.Add(Magier1);
            players.Add(Schamane1);

            playerlist = players;
            Eigenschaften eigform;
            Actions actform;
            foreach (MeltonCreature creature in players)
            {
                eigform = new Eigenschaften(this, creature);
                actform = new Actions(this, creature);
                eigform.Tag = creature;
                actform.Tag = creature;
                FormManager.GetInstance().AddEig(eigform, creature.Name);
                FormManager.GetInstance().AddAct(actform, creature.Name);
                MoveOfWarrior = actform.Warriormove;
                MoveOfMage = actform.Magemove;
                MoveOfHunter = actform.Huntermove;
                MoveOfShaman = actform.Shamanmove;
            }
            eigform = new Eigenschaften(this, EvilBoss1);
            eigform.Tag = EvilBoss1;
            FormManager.GetInstance().AddEig(eigform, EvilBoss1.Name);
            ButtonArray();
        }
        private void ButtonArray()
        {
            for (int i = 0; i < 81; i++)
            {
                btn = new Button();
                btn.BackgroundImage = null;
                btn.Name = "";
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.Transparent;
                btn.Size = new Size(80, 80);
                btn.ForeColor = Color.Black;
                btn.AllowDrop = true;
                btn.MouseDown += btn_MouseDown;
                btn.DragEnter += btn_DragEnter;
                btn.DragDrop += btn_DragDrop;
                btn.Tag = (int)i;
                flowLayoutPanel1.Controls.Add(btn);
                if ((int)btn.Tag == EvilBoss.Position && bossdeath == false)
                {
                    btn.BackgroundImage = Properties.Resources.Boss;
                    btn.Name = EvilBoss.Name;
                }
                else if (bossdeath == true)
                {
                    EvilBoss.Name = null;
                    if ((int)btn.Tag == EvilBoss.Position && bossdeath == false)
                {
                    btn.BackgroundImage = Properties.Resources.Boss;
                    btn.Name = EvilBoss.Name;
                }
                }
                if ((int)btn.Tag == Krieger.Position && warriordeath == false)
                {
                    if (MoveOfWarrior == true)
                    {
                        btn.BackgroundImage = Properties.Resources.Warriorzug;
                    }
                    else
                    {
                        btn.BackgroundImage = Properties.Resources.Warrior;
                    }
                    btn.Name = Krieger.Name;
                }
                else if (warriordeath == true)
                {
                    Krieger.Name = null;
                }
                if ((int)btn.Tag == Magier.Position && magedeath == false)
                {
                    if (MoveOfMage == true)
                    {
                        btn.BackgroundImage = Properties.Resources.Magezug;
                    }
                    else
                    {
                        btn.BackgroundImage = Properties.Resources.Mage;
                    }
                    btn.Name = Magier.Name;
                }
                else if (magedeath == true)
                {
                    Magier.Name = null;
                }
                if ((int)btn.Tag == Jaeger.Position && hunterdeath == false)
                {
                    if (MoveOfHunter == true)
                    {
                        btn.BackgroundImage = Properties.Resources.Hunterzug;
                    }
                    else
                    {
                        btn.BackgroundImage = Properties.Resources.Hunter;
                    }
                    btn.Name = Jaeger.Name;
                }
                else if (hunterdeath == true)
                {
                    Jaeger.Name = null;
                }
                if ((int)btn.Tag == Schamane.Position && shamandeath == false)
                {
                    if (MoveOfShaman == true)
                    {
                        btn.BackgroundImage = Properties.Resources.Druidzug;
                    }
                    else
                    {
                        btn.BackgroundImage = Properties.Resources.Druid;
                    }
                    btn.Name = Schamane.Name;
                }
                else if (shamandeath == true)
                {
                    Schamane.Name = null;
                    
                }
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                if(Krieger.Health <= 0)
                {
                    Krieger.Health = 0;
                    warriordeath = true;
                    MoveOfWarrior = true;
                }
                if(Magier.Health <= 0)
                {
                    Magier.Health = 0;
                    magedeath = true;
                    MoveOfMage = true;
                }
                if(Jaeger.Health <= 0)
                {
                    Jaeger.Health = 0;
                    hunterdeath = true;
                    MoveOfHunter = true;
                }
                if(Schamane.Health <= 0)
                {
                    Schamane.Health = 0;
                    shamandeath = true;
                    MoveOfShaman = true;
                }
            }
        }
        private void BoardUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (eigenschaften != null)
                eigenschaften.Close();
            if (action != null)
                action.Close();
            Startmenu Menu = new Startmenu(game);
            Menu.MdiParent = game;
        }
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btndrag = (Button)sender;
            Btndragclass = btndrag;
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Copy);
            }
        }
        private void btn_DragEnter(object sender, DragEventArgs e)
        {
            Button btndrop = (Button)sender;
            Btndropclass = btndrop;
            e.Effect = DragDropEffects.Copy;
        }
        private void btn_DragDrop(object sender, DragEventArgs e)
        {
            Button btnPos = (Button)sender;
            if (btnPos.Name.Contains("player") || btnPos.Name.Contains("Boss"))
            {
                if (eigenschaften != null)
                    eigenschaften.Hide();
                if (action != null)
                    action.Hide();
               
                action = FormManager.GetInstance().GetAct(btnPos.Name);
                if (action != null)
                {
                    action.MdiParent = parent;
                    action.Show();
                    action.Location = new Point(this.Location.X, this.Location.Y + 768);
                }

                eigenschaften = FormManager.GetInstance().GetEig(btnPos.Name);
                eigenschaften.MdiParent = parent;
                eigenschaften.Show();
                eigenschaften.Location = new Point(this.Location.X + 776, this.Location.Y);
            }
            else
            {
                if (action != null)
                    action.Hide();
                if (eigenschaften != null)
                    eigenschaften.Hide();
            }
            if (((int)btndragclass.Tag + 1) == (int)btndropclass.Tag || ((int)btndragclass.Tag - 1) == (int)btndropclass.Tag || ((int)btndragclass.Tag + 8) == (int)btndropclass.Tag || ((int)btndragclass.Tag - 8) == (int)btndropclass.Tag || ((int)btndragclass.Tag + 9) == (int)btndropclass.Tag || ((int)btndragclass.Tag - 9) == (int)btndropclass.Tag || ((int)btndragclass.Tag + 10) == (int)btndropclass.Tag || ((int)btndragclass.Tag - 10) == (int)btndropclass.Tag)
            {
                if (btndragclass.Name.Contains("Krieger") && MoveOfWarrior == false)
                {
                    Btndropclass.BackgroundImage = Btndragclass.BackgroundImage;
                    Btndropclass.Name = Btndragclass.Name;
                    MoveOfWarrior = true;
                }
                if (btndragclass.Name.Contains("Magier") && MoveOfMage == false)
                {
                    Btndropclass.BackgroundImage = Btndragclass.BackgroundImage;
                    Btndropclass.Name = Btndragclass.Name;
                    MoveOfMage = true;
                }
                if (btndragclass.Name.Contains("Jäger") && MoveOfHunter == false)
                {
                    Btndropclass.BackgroundImage = Btndragclass.BackgroundImage;
                    Btndropclass.Name = Btndragclass.Name;
                    MoveOfHunter = true;
                }
                if (btndragclass.Name.Contains("Schamane") && MoveOfShaman == false)
                {
                    Btndropclass.BackgroundImage = Btndragclass.BackgroundImage;
                    Btndropclass.Name = Btndragclass.Name;
                    MoveOfShaman = true;
                }
            }
            if (btnPos.Name.Contains("Krieger"))
            {
                Krieger.Position = (int)btnPos.Tag;
            }
            if (btnPos.Name.Contains("Magier"))
            {
                Magier.Position = (int)btnPos.Tag;
            }
            if (btnPos.Name.Contains("Jäger"))
            {
                Jaeger.Position = (int)btnPos.Tag;
            }
            if (btnPos.Name.Contains("Schamane"))
            {
                Schamane.Position = (int)btnPos.Tag;
            }
            flowLayoutPanel1.Controls.Clear();
            ButtonArray();
            if (MoveOfWarrior == true && MoveOfMage == true && MoveOfHunter == true && MoveOfShaman == true)
            {
                foreach (MeltonCreature player in playerlist)
                {
                    if(specialcounter >= 2)
                    {
                        EvilBoss.DoSpecialAttack(player);
                    }
                    else if ((EvilBoss.Position + 1) == player.Position || (EvilBoss.Position - 1) == player.Position || (EvilBoss.Position + 2) == player.Position || (EvilBoss.Position - 2) == player.Position || (EvilBoss.Position + 7) == player.Position || (EvilBoss.Position - 7) == player.Position || (EvilBoss.Position + 9) == player.Position || (EvilBoss.Position - 9) == player.Position || (EvilBoss.Position + 10) == player.Position || (EvilBoss.Position - 10) == player.Position || (EvilBoss.Position + 11) == player.Position || (EvilBoss.Position - 11) == player.Position || (EvilBoss.Position + 16) == player.Position || (EvilBoss.Position - 16) == player.Position || (EvilBoss.Position + 17) == player.Position || (EvilBoss.Position - 17) == player.Position || (EvilBoss.Position + 18) == player.Position || (EvilBoss.Position - 18) == player.Position || (EvilBoss.Position + 19) == player.Position || (EvilBoss.Position - 19) == player.Position || (EvilBoss.Position + 20) == player.Position || (EvilBoss.Position - 20) == player.Position)
                    {
                        EvilBoss.DoAttack(player);
                        MessageBox.Show("Boss hat angegriffen");
                    }
                    else
                    {
                        specialcounter += 1;
                        MessageBox.Show("Boss konnte nicht angreifen");
                    }
                    MoveOfWarrior = false;
                    MoveOfMage = false;
                    MoveOfHunter = false;
                    MoveOfShaman = false;
                }
            }
            if (EvilBoss.Health <= 0)
            {
                end = new EndMenu("You Won");
                end.TopMost = true;
                end.Show();
            }
            else if (Krieger.Health <= 0 && Jaeger.Health <= 0 && Magier.Health <= 0 && Schamane.Health <= 0)
            {
                end = new EndMenu("You Lost");
                end.TopMost = true;
                end.Show();
            }
        }
        private void BoardUI_Load(object sender, EventArgs e)
        {
            
            LoadingScreen load = new LoadingScreen();
            load.TopMost = true;
            load.Show();
            Gameloading(EvilBoss.Name);
            Gameloading(Krieger.Name);
            Gameloading(Magier.Name);
            Gameloading(Jaeger.Name);
            Gameloading(Schamane.Name);
            game.Hide(); 
        }
        private void Gameloading(string playername)
        {
            if (eigenschaften != null)
                eigenschaften.Hide();
            if (action != null)
                action.Hide();

            action = FormManager.GetInstance().GetAct(playername);
            if (action != null)
            {
                action.MdiParent = parent;
                action.Show();
                action.Location = new Point(this.Location.X, this.Location.Y + 768);
            }

            eigenschaften = FormManager.GetInstance().GetEig(playername);
            eigenschaften.MdiParent = parent;
            eigenschaften.Show();
            eigenschaften.Location = new Point(this.Location.X + 776, this.Location.Y);
        }
    }
}
