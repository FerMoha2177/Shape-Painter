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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Color.White;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("You chose" + dlg.Color.ToString());
                form.BackColor = dlg.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
