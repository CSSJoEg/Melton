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
    public partial class Characters : Form
    {
        public Form parent { get; set; }
        public Characters(Form mdiParent)
        {
            InitializeComponent();
            parent = mdiParent;
			System.Drawing.Drawing2D.GraphicsPath cW = new System.Drawing.Drawing2D.GraphicsPath();
			cW.AddEllipse(0, 0, pictureWarrior.Width - 1, pictureWarrior.Height - 1);
			Region rgW = new Region(cW);
			pictureWarrior.Region = rgW;

			System.Drawing.Drawing2D.GraphicsPath cM = new System.Drawing.Drawing2D.GraphicsPath();
			cW.AddEllipse(0, 0, pictureMage.Width - 1, pictureMage.Height - 1);
			Region rgM = new Region(cM);
			pictureMage.Region = rgM;
			//System.Drawing.Drawing2D.GraphicsPath cS = new System.Drawing.Drawing2D.GraphicsPath();
			//cW.AddEllipse(0, 0, pictureShaman.Width - 2, pictureShaman.Height - 2);
			//Region rgS = new Region(cS);
			//pictureShaman.Region = rgS;
			//System.Drawing.Drawing2D.GraphicsPath cHW = new System.Drawing.Drawing2D.GraphicsPath();
			//cW.AddEllipse(0, 0, pictureWarlock.Width - 2, pictureWarlock.Height - 2);
			//Region rgHW = new Region(cHW);
			//pictureWarlock.Region = rgHW;
			//System.Drawing.Drawing2D.GraphicsPath cP = new System.Drawing.Drawing2D.GraphicsPath();
			//cW.AddEllipse(0, 0, picturePriest.Width - 2, picturePriest.Height - 2);
			//Region rgP = new Region(cP);
			//picturePriest.Region = rgP;
			//System.Drawing.Drawing2D.GraphicsPath cR = new System.Drawing.Drawing2D.GraphicsPath();
			//cW.AddEllipse(0, 0, pictureRogue.Width - 2, pictureRogue.Height - 2);
			//Region rgR = new Region(cR);
			//pictureRogue.Region = rgR;
			//System.Drawing.Drawing2D.GraphicsPath cH = new System.Drawing.Drawing2D.GraphicsPath();
			//cW.AddEllipse(0, 0, pictureHunter.Width - 2, pictureHunter.Height - 2);
			//Region rgH = new Region(cH);
			//pictureHunter.Region = rgH;



		}
	}
}
