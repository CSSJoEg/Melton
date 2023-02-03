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
        enum ThemeColor
        {
            Primary,
            Secondary,
            Tertiary,
            Text
        }
        void ChangeTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {

        }
        public Form parent { get; set; }
        public Settings(Form mdiParent)
        {
            InitializeComponent();
            parent = mdiParent;
            Light = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.WhiteSmoke },
            { ThemeColor.Secondary, Color.Silver },
            { ThemeColor.Tertiary, Color.White },
            { ThemeColor.Text, Color.Black }
            };
            Nature = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.DarkSeaGreen },
            { ThemeColor.Secondary, Color.AliceBlue },
            { ThemeColor.Tertiary, Color.Honeydew },
            { ThemeColor.Text, Color.Black }
            };
            Dark = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.DimGray },
            { ThemeColor.Secondary, Color.DimGray },
            { ThemeColor.Tertiary, Color.Black },
            { ThemeColor.Text, Color.White }
            };
            Dictionary<ThemeColor, Color> Light = new Dictionary<ThemeColor, Color>();
            Dictionary<ThemeColor, Color> Nature = new Dictionary<ThemeColor, Color>();
            Dictionary<ThemeColor, Color> Dark = new Dictionary<ThemeColor, Color>();
        }
        
        private void DarkmodeOn_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkmodeOn.Checked)
            {
                ChangeTheme(Light[ThemeColor.Primary], Light[ThemeColor.Secondary], Light[ThemeColor.Tertiary]);
                ChangeTextColor(Light[ThemeColor.Text]);
            }
        }
    }
}

