using Assignment3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class OathDialog : BaseDialogForm
    {
        //Form Oath = new Form();
        
        public OathDialog()
        {

            InitializeComponent();
           // this.Paint += new System.Windows.Forms.PaintEventHandler(this.OathDialog_Paint);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //BaseTextbox.AppendText("As a student of this University: I will be honest in my academic endeavors. I will not represent someone else's work as my own. I will not cheat, nor will I aid in another's cheating.");
            //BaseLabel.Text= "As a student of this University: I will be honest in my academic endeavors.\r\n I will not represent someone else's work as my own. \r\nI will not cheat, nor will I aid in another's cheating.";
            //BaseLabel.ForeColor = Color.Orange;
        }
        private void OathDialog_Paint(object sender, PaintEventArgs e)
        {
            //Point[] quadPoints = new Point[] { new Point(30, 0), new Point(0, 20), new Point(30, 20), new Point(0, 0) };
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            Graphics g = e.Graphics;
            GraphicsPath graPath = new GraphicsPath();
            //graPath.AddPolygon(quadPoints);
            graPath.AddRectangle(rect);
            PathGradientBrush graBrush = new PathGradientBrush(graPath);
            graBrush.WrapMode = WrapMode.Tile;

            graBrush.SurroundColors = new Color[] { Color.Red, Color.Blue, Color.Black, Color.Purple };

            e.Graphics.FillRectangle(graBrush, rect.X, rect.Y, this.Width, this.Height);
            //e.Graphics.FillPath(graBrush, graPath);

        }

 
    }
}

        
