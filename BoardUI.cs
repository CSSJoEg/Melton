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

namespace Melton
{
    public partial class BoardUI : Form
    {
        Game game = (Game)Application.OpenForms["game"];
        Eigenschaften eigenschaften;
        Actions action;
        Button btn = new Button();
        Boss evilboss;
        Warrior krieger;
        Hunter hunter;
        Mage magier;
        Shaman schamane;
        List<MeltonCreature> playerlist = new List<MeltonCreature>();
        public Form parent { get; set; }
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
            flowLayoutPanel1.BackgroundImage = Properties.Resources.background;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            parent = mdiParent;
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
            List<MeltonCreature> players = new List<MeltonCreature>();

            players.Add(Krieger1);
            players.Add(Jaeger1);
            players.Add(Magier1);
            players.Add(Schamane1);

            Eigenschaften form; 
            foreach (MeltonCreature creature in players)
            {
                form = new Eigenschaften(this, creature);
                form.Tag = creature;
                FormManager.GetInstance().Add(form, creature.Name);
            }
            form = new Eigenschaften(this, EvilBoss1);
            form.Tag = EvilBoss1;
            FormManager.GetInstance().Add(form, EvilBoss1.Name);
            ButtonArray();
        }
        private void ButtonArray()
        {
            for (int i = 0; i < 81; i++)
            {
                btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor= Color.Transparent;
                btn.Size = new Size(80, 80);
                btn.ForeColor = Color.Black;
                btn.Tag = (int)i;
                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
                if ((int)btn.Tag == 22)
                {
                    btn.BackgroundImage = Properties.Resources.Boss;
                    btn.Name = EvilBoss.Name;
                    EvilBoss.Position = (int)btn.Tag;
                }
                if ((int)btn.Tag == 56)
                {
                    btn.BackgroundImage = Properties.Resources.Warrior;
                    btn.Name = Krieger.Name;
                    Krieger.Position = (int)btn.Tag;
                }
                if ((int)btn.Tag == 57)
                {
                    btn.BackgroundImage = Properties.Resources.Mage;
                    btn.Name = Magier.Name;
                    Magier.Position = (int)btn.Tag;
                }
                if ((int) btn.Tag == 59)
                {
                    btn.BackgroundImage = Properties.Resources.Hunter;
                    btn.Name = Jaeger.Name;
                    Jaeger.Position = (int)btn.Tag;
                }
                if ((int) btn.Tag == 60)
                {
                    btn.BackgroundImage = Properties.Resources.Druid;
                    btn.Name = Schamane.Name;
                    Schamane.Position = (int)btn.Tag;
                }
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            Button btnPos = (Button)sender;
            if (btnPos.Name.Contains("player") || btnPos.Name.Contains("Boss"))
            {
                if(btnPos.Name.Contains("Krieger"))
                {
                    action = new Actions(this, Krieger);
                }
                else if (btnPos.Name.Contains("Magier"))
                {
                    action = new Actions(this, Magier);
                }
                else if (btnPos.Name.Contains("Jäger"))
                {
                    action = new Actions(this, Jaeger);
                }
                else if (btnPos.Name.Contains("Schamane"))
                {
                    action = new Actions(this, Schamane);
                }
                if (eigenschaften != null)
                    eigenschaften.Hide();
                eigenschaften = FormManager.GetInstance().Get(btnPos.Name);        
                eigenschaften.MdiParent = parent;
                action.MdiParent = parent;
                eigenschaften.Show();
                action.Show();
                eigenschaften.Location = new Point(this.Location.X + 776, this.Location.Y);
                action.Location = new Point(this.Location.X, this.Location.Y + 776);
            }
            else
            {
                if(action != null)
                    action.Hide();
                if (eigenschaften != null)
                    eigenschaften.Hide();
            }
        }
        public void BoardUI_LocationChanged(object sender, EventArgs e)
        {
            if (eigenschaften != null)
            {
                eigenschaften.Location = new Point(this.Location.X + 776, this.Location.Y);
                action.Location = new Point(this.Location.X, this.Location.Y + 776);
            }
        }
        private void BoardUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(eigenschaften != null)
                eigenschaften.Close();
            if (action != null)
                action.Close();
            Startmenu Menu = new Startmenu(game);
            Menu.MdiParent = game;
            Menu.Show();
        }
    }
}
