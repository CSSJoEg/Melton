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

namespace Melton
{
    public partial class BoardUI : Form
    {
        Game game = (Game)Application.OpenForms["game"];
        Eigenschaften eigenschaften;
        Actions action = new Actions();
        Button btn = new Button();
        string name;
        Boss evilboss;
        Warrior krieger;
        Hunter hunter;
        Mage magier;
        Shaman schamane;
        public Form parent { get; set; }
        public string positionname
        {
            get { return name; }
            set { name = value; }
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
        public BoardUI(Form mdiParent)
        {
            InitializeComponent();
            ButtonArray();
            eigenschaften = new Eigenschaften(this);
            flowLayoutPanel1.BackgroundImage = Properties.Resources.background;
            parent = mdiParent;
            StartPosition = FormStartPosition.CenterScreen;
            eigenschaften.Hide();
            action.Hide();
            Boss EvilBoss1 = new Boss()
            {
                Attack = 40,
                AOE = 20,
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
                Name = "Krieger"
            };
            Krieger = Krieger1;
            Hunter Jaeger1 = new Hunter()
            {
                Attack = 30,
                AttackSpeed = 0.2F,
                Energy = 100,
                Health = 60,
                MaxHealth = 60,
                Name = "Jäger"
            };
            Jaeger = Jaeger1;
            Mage Magier1 = new Mage()
            {
                Attack = 50,
                AttackSpeed = 0.6F,
                Mana = 100,
                Health = 60,
                MaxHealth = 60,
                Name = "Magier"
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
                Name = "Schamane"
            };
            Schamane = Schamane1;
            List<MeltonCreature> players = new List<MeltonCreature>()
           ;
            players.Add(Krieger1);
            players.Add(Jaeger1);
            players.Add(Magier1);
            players.Add(Schamane1);
        }
        public void ButtonArray()
        {
            for (int i = 0; i < 81; i++)
            {
                btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor= Color.Black;
                btn.Size = new Size(80, 80);
                btn.ForeColor= Color.Black;
                btn.Text = i.ToString();
                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
                if (btn.Text == "22")
                {
                    btn.BackgroundImage = Properties.Resources.Boss;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Name = "boss";
                }
                if (btn.Text == "56")
                {
                    btn.BackgroundImage = Properties.Resources.Warrior;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Name = "player.Warrior";
                }
                if (btn.Text == "57")
                {
                    btn.BackgroundImage = Properties.Resources.Mage;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Name = "player.Mage";
                }
                if (btn.Text == "59")
                {
                    btn.BackgroundImage = Properties.Resources.Hunter;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Name = "player.Hunter";
                }
                if (btn.Text == "60")
                {
                    btn.BackgroundImage = Properties.Resources.Druid;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Name = "player.Shaman";
                }
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            Button btnPos = (Button)sender;
            positionname = btnPos.Name;
            if (btnPos.Name.Contains("player") || btnPos.Name.Contains("boss"))
            {
                eigenschaften.MdiParent = parent;
                action.MdiParent = parent;
                action.Show();
                eigenschaften.Show();
                action.Location = new Point(this.Location.X, this.Location.Y + 813);
                eigenschaften.Location = new Point(this.Location.X + 796, this.Location.Y);
            }
            else
            {
                action.Hide();
                eigenschaften.Hide();
            }
        }
        public void BoardUI_LocationChanged(object sender, EventArgs e)
        {
            if (eigenschaften != null)
            {
                eigenschaften.Location = new Point(this.Location.X + 796, this.Location.Y);
                action.Location = new Point(this.Location.X, this.Location.Y + 813);
            }
        }
        private void BoardUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            eigenschaften.Close();
            action.Close();
            Startmenu Menu = new Startmenu(game);
            Menu.MdiParent = game;
            Menu.Show();
        }
    }
}
