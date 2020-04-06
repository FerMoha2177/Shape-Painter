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
    public partial class AboutDialog : BaseDialogForm
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutDialog_Paint(object sender, PaintEventArgs e)
        {
            /*//Point[] quadPoints = new Point[] { new Point(30, 0), new Point(0, 20), new Point(30, 20), new Point(0, 0) };
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            Graphics g = e.Graphics;
            GraphicsPath graPath = new GraphicsPath();
            //graPath.AddPolygon(quadPoints);
            graPath.AddRectangle(rect);
            PathGradientBrush graBrush = new PathGradientBrush(graPath);
            graBrush.WrapMode = WrapMode.Tile;

            graBrush.SurroundColors = new Color[] { Color.Red, Color.Blue, Color.Black, Color.Purple };

            e.Graphics.FillRectangle(graBrush, rect.X, rect.Y, this.Width, this.Height);
            //e.Graphics.FillPath(graBrush, graPath);*/
            Point begin = new Point(0, 0);
            Point end = new Point(0, this.ClientSize.Width);
            LinearGradientBrush brush = new LinearGradientBrush(begin, end, Color.White, Color.Red);
            ColorBlend blend = new ColorBlend();
            blend.Positions = new[] {0F, 1/2F, 1F };
            blend.Colors = new[] { Color.Red, Color.Blue, Color.Yellow };
            brush.InterpolationColors = blend;
            brush.RotateTransform(45);
            Pen blackPen = new Pen(brush, 15);
            e.Graphics.DrawRectangle(blackPen, 0, 00, this.ClientSize.Width, this.ClientSize.Height);

        }
    }
}
