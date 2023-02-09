using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Melton
{
    public partial class Settings : Form
    {
        Game game = (Game)Application.OpenForms["game"];
        Dictionary<ThemeColor, Color> Sky;
        Dictionary<ThemeColor, Color> Blood;
        Dictionary<ThemeColor, Color> Nature;
        Dictionary<ThemeColor, Color> Dark;
        Dictionary<ThemeColor, Color> TextColor;
        enum ThemeColor
        {
            Primary,
            Secondary,
            Tertiary,
            LightText,
            DarkText
        }
        void ChangeTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {
            this.BackColor = primaryColor;
            foreach (Control c in this.Controls)
            {
                c.BackColor = secondaryColor;
                c.ForeColor = tertiaryColor;
            }
        }
        void ChangeTextColor(Color textcolor)
        {
            foreach (Control l in this.Controls)
            {
                l.ForeColor = textcolor;
                if (l.GetType() == typeof(Label))
                    l.ForeColor = textcolor;
            }
        }
        void ColorReset()
        {
            foreach (Control c in this.Controls)
            {
                c.BackColor = DefaultBackColor;
                c.ForeColor = DefaultForeColor;
                if (c.GetType() == typeof(Label))
                    c.ForeColor = DefaultForeColor;
            }
        }
        public Form parent { get; set; }
        public Settings(Form mdiParent)
        {
            InitializeComponent();
            Sky = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.FromArgb(114, 134, 211) },
            { ThemeColor.Secondary, Color.FromArgb(142, 167, 233) },
            { ThemeColor.Tertiary, Color.FromArgb(229, 224, 255) },
            };
            Blood = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.FromArgb(99, 6, 6) },
            { ThemeColor.Secondary, Color.FromArgb(137, 15, 13) },
            { ThemeColor.Tertiary, Color.FromArgb(232, 58, 20) },
            };
            Nature = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.DarkSlateGray },
            { ThemeColor.Secondary, Color.FromArgb(55, 146, 55) },
            { ThemeColor.Tertiary, Color.FromArgb(130, 205, 71) },
            };
            Dark = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.Black },
            { ThemeColor.Secondary, Color.DarkGray },
            { ThemeColor.Tertiary, Color.Red },
            };
            TextColor = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.LightText, Color.White },
            { ThemeColor.DarkText, Color.Black },
            };
            parent = mdiParent;
        }
        private void SkyTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (SkyTheme.Checked)
            {
                ChangeTheme(Sky[ThemeColor.Primary], Sky[ThemeColor.Secondary], Sky[ThemeColor.Tertiary]);
                DarkMode.Checked = false;
                LightText.Checked = false;
                DarkText.Checked = false;
            }
            else if (!NatureTheme.Checked && !BloodTheme.Checked)
            {
                ColorReset();
            }
            else
            {
                SkyTheme.Checked = false;
            }
        }
        private void NatureTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (NatureTheme.Checked)
            {
                ChangeTheme(Nature[ThemeColor.Primary], Nature[ThemeColor.Secondary], Nature[ThemeColor.Tertiary]);
                DarkMode.Checked = false;
                LightText.Checked = false;
                DarkText.Checked = false;
            }
            else if (!SkyTheme.Checked && !BloodTheme.Checked)
            {
                ColorReset();
            }
            else
            {
                NatureTheme.Checked = false;
            }
        }
        private void BloodTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (BloodTheme.Checked)
            {
                ChangeTheme(Blood[ThemeColor.Primary], Blood[ThemeColor.Secondary], Blood[ThemeColor.Tertiary]);
                DarkMode.Checked = false;
                LightText.Checked = false;
                DarkText.Checked = false;
            }
            else if (!SkyTheme.Checked && !NatureTheme.Checked)
            {
                ColorReset();
            }
            else
            {
                BloodTheme.Checked = false;
            }
        }
        private void DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkMode.Checked)
            {
                ChangeTheme(Dark[ThemeColor.Primary], Dark[ThemeColor.Secondary], Dark[ThemeColor.Tertiary]);
                SkyTheme.Checked = false;
                NatureTheme.Checked = false;
                BloodTheme.Checked = false;
            }
            else if (!SkyTheme.Checked && !NatureTheme.Checked && !BloodTheme.Checked)
            {
                ColorReset();
            }
            else
            {
                DarkMode.Checked = false;
            }
        }
        private void LightText_CheckedChanged(object sender, EventArgs e)
        {
            if (LightText.Checked)
            {
                ChangeTextColor(TextColor[ThemeColor.LightText]);
            }
            else if (!DarkText.Checked)
            {
                ColorReset();
            }
            else
            {
                LightText.Checked = false;
            }
        }

        private void DarkText_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkText.Checked)
            {
                ChangeTextColor(TextColor[ThemeColor.DarkText]);
            }
            else if (!LightText.Checked)
            {
                ColorReset();
            }
            else
            {
                DarkText.Checked = false;
            }
        }
		private void change_layout_Click(object sender, EventArgs e)
		{

		}
	}
}