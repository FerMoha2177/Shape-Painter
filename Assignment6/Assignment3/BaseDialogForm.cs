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
    public partial class BaseDialogForm : Form
    {
        public BaseDialogForm()
        {
            InitializeComponent();
        }

        private void courseSemesterForm1_Load(object sender, EventArgs e)
        {

        }

        private void BaseDialogForm_Load(object sender, EventArgs e)
        {

            //this.courseSemesterForm.BackColor = this.BackColor;
            //this.courseSemesterForm.BackgroundImage = this.BackgroundImage;

           /* foreach (Control ctrl in this.courseSemesterForm.Controls)
            {

                ctrl.BackColor = this.BackColor;
                ctrl.BackgroundImage = this.BackgroundImage;

            }*/

            //this.CenterPanel.BackColor = this.BackColor;
            //this.CenterPanel.BackgroundImage = this.BackgroundImage;


        }

        private void Name_Load(object sender, EventArgs e)
        {

        }

        private void Blankspace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void BaseTextbox_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(BaseTextbox.Text, BaseTextbox.Font);
            BaseTextbox.Width = size.Width;
            BaseTextbox.Height = size.Height;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BaseLabel_Click(object sender, EventArgs e)
        {

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
