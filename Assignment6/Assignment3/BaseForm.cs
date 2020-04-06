using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class BaseForm : Form
    {
        Point downPoint = Point.Empty;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void ColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Color.White;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("You chose" + dlg.Color.ToString());
                this.BackColor = dlg.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;
            Point location =
            new Point(
            this.Left + e.X - downPoint.X,
            this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }

        private void Close_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        public virtual void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {

            throw new NotImplementedException();

        }

        public virtual void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            throw new NotImplementedException();

        }
    }
}
