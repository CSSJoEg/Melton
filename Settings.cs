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
        Dictionary<ThemeColor, Color> Light;
        Dictionary<ThemeColor, Color> Nature;
        Dictionary<ThemeColor, Color> Dark;
        enum ThemeColor
        {
            Primary,
            Secondary,
            Tertiary,
            Text
        }
        void ChangeTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {
            Light = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.WhiteSmoke },
            { ThemeColor.Secondary, Color.Silver },
            { ThemeColor.Tertiary, Color.White },
            };
            Nature = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.DarkSeaGreen },
            { ThemeColor.Secondary, Color.AliceBlue },
            { ThemeColor.Tertiary, Color.Honeydew },
            };
            Dark = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.DimGray },
            { ThemeColor.Secondary, Color.DimGray },
            { ThemeColor.Tertiary, Color.Black },
            };
        }
        void ChangeTextColor(Color textcolor)
		{
            Light = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Text, Color.Black }
            };
            Nature = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Text, Color.Black }
            };
            Dark = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Text, Color.White }
            };
        }
        public Form parent { get; set; }
        public Settings(Form mdiParent)
        {
            InitializeComponent();
            parent = mdiParent;
        }
		private void Light_Theme_CheckedChanged_1(object sender, EventArgs e)
		{
            if (Light_Theme.Checked)
            {
                ChangeTheme(Light[ThemeColor.Primary], Light[ThemeColor.Secondary], Light[ThemeColor.Tertiary]);
                ChangeTextColor(Light[ThemeColor.Text]);
            }
        }
	}
}

