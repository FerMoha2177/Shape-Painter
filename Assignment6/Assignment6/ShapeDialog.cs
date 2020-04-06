using System;
using System.Linq;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class ShapeDialog : Form, IShapeDialog
    {
        Document document;

        public event EventHandler apply;

        public string WidthText
        {
            get { return this.SizeWidthText.Text; }
            set { this.SizeWidthText.Text = value; }
        }

        public TextBox WidthTextBox
        {
            get { return this.SizeWidthText; }
        }

        public TextBox HeightTextBox
        { 
            get { return this.SizeHeightText; }
        }
       
        public string HeightText
        { 
            get { return this.SizeHeightText.Text; }
            set { this.SizeHeightText.Text = value; }
        }

        public string LocationX
        {
            get { return this.LocationXText.Text; }
            set { this.LocationXText.Text = value; }
        }

        public string LocationY
        {
            get { return this.LocationYText.Text; }
            set { this.LocationYText.Text = value; }
        }

        public TextBox LocationXTextBox
        {
            get { return this.LocationXText; }
            set { this.LocationXText = value; }
        }

        public TextBox LocationYTextBox
        {
            get { return this.LocationYText; }
            set { this.LocationYText = value; }
        }

        public ShapeDialog(Document document, int index)
        {
            InitializeComponent();

            this.document = document;

            BindingManager.Position = index;

            this.PenBindingLabel.DataBindings.Add("Text", this.document.Shapes, "TypeOfPen", true, DataSourceUpdateMode.OnPropertyChanged);
            this.BrushBindingLabel.DataBindings.Add("Text", this.document.Shapes, "TypeOfBrush", true, DataSourceUpdateMode.OnPropertyChanged);
            this.PenColorButton.DataBindings.Add("BackColor", this.document.Shapes, "PenColor");
            this.BrushColorButton.DataBindings.Add("BackColor", this.document.Shapes, "BrushColor");
            this.WidthTextBox.DataBindings.Add("Text", this.document.Shapes, "ShapeWidth");
            this.HeightTextBox.DataBindings.Add("Text", this.document.Shapes, "ShapeHeight");
            this.LocationXTextBox.DataBindings.Add("Text", this.document.Shapes, "ShapeLocationX");
            this.LocationYTextBox.DataBindings.Add("Text", this.document.Shapes, "ShapeLocationY");

            this.document.Shapes.ElementAt(index).isHighlighted(true);

             RefreshItems();





        }

        BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.document.Shapes]; }
        }
        
        void moveFirstButton_Click(object sender, EventArgs e)
        {
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(false);
            this.BindingManager.Position = 0;
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(true);
            this.OKButton.PerformClick();
            RefreshItems();
        }
        
        void movePreviousButton_Click(object sender, EventArgs e)
        {
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(false);
            // No need to worry about being < 0
            --this.BindingManager.Position;
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(true);
            this.OKButton.PerformClick();
            RefreshItems();
        }
        
        void moveNextButton_Click(object sender, EventArgs e)
        {
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(false);
            // No need to worry about being > BindingManager.Count
            ++this.BindingManager.Position;
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(true);
            this.OKButton.PerformClick();
            RefreshItems();
        }
        
        void moveLastButton_Click(object sender, EventArgs e)
        {
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(false);
            this.BindingManager.Position = this.BindingManager.Count - 1;
            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(true);
            this.OKButton.PerformClick();
            RefreshItems();
        }

        private void SolidCheckBox_Click(object sender, EventArgs e)
        {
            this.PenBindingLabel.Text = Shape.PenType.Solid.ToString();
            penCheckBox(Shape.PenType.Solid);
        }

        private void DashedCheckBox_Click(object sender, EventArgs e)
        {
            this.PenBindingLabel.Text = Shape.PenType.Dashed.ToString();
            penCheckBox(Shape.PenType.Dashed);
        }

        private void CompoundCheckBox_Click(object sender, EventArgs e)
        {
            this.PenBindingLabel.Text = Shape.PenType.Compound.ToString();
            penCheckBox(Shape.PenType.Compound);
        }

        private void LinearGradientCheckBox_Click(object sender, EventArgs e)
        {
            this.BrushBindingLabel.Text = Shape.BrushType.LinearGradient.ToString();
            brushCheckBox(Shape.BrushType.LinearGradient);
        }

        private void SolidBrushCheckBox_Click(object sender, EventArgs e)
        {
            this.BrushBindingLabel.Text = Shape.BrushType.Solid.ToString();
            brushCheckBox(Shape.BrushType.Solid);
        }

        private void HatchedCheckBox_Click(object sender, EventArgs e)
        {
            this.BrushBindingLabel.Text = Shape.BrushType.Hatched.ToString();
            brushCheckBox(Shape.BrushType.Hatched);
        }

        private void brushCheckBox(Shape.BrushType brushType)
        {
            this.HatchedCheckBox.Checked = false;
            this.SolidBrushCheckBox.Checked = false;
            this.LinearGradientCheckBox.Checked = false;

            switch (brushType)
            {
                case Shape.BrushType.Solid:
                    this.SolidBrushCheckBox.Checked = true;
                    break;
                case Shape.BrushType.LinearGradient:
                    this.LinearGradientCheckBox.Checked = true;
                    break;
                case Shape.BrushType.Hatched:
                    this.HatchedCheckBox.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void penCheckBox(Shape.PenType penType)
        {
            this.SolidCheckBox.Checked = false;
            this.DashedCheckBox.Checked = false;
            this.CompoundCheckBox.Checked = false;

            switch (penType)
            {
                case Shape.PenType.Solid:
                    this.SolidCheckBox.Checked = true;
                    break;
                case Shape.PenType.Dashed:
                    DashedCheckBox.Checked = true;
                    break;
                case Shape.PenType.Compound:
                    this.CompoundCheckBox.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void PenColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.PenColorButton.BackColor = colorDialog.Color;
                }
            }
        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BrushColorButton.BackColor = colorDialog.Color;
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(apply != null)
            {
                apply(this, EventArgs.Empty);
            }
        }

        void RefreshItems()
        {
            int count = this.BindingManager.Count;
            int position = this.BindingManager.Position + 1;
            // Update count and position text
            this.bindingNavigatorCountItem.Text = count.ToString();
            this.bindingNavigatorPositionItem.Text = position.ToString();
            // Enable or disable move buttons
            this.bindingNavigatorMoveFirstItem.Enabled = (position > 1);
            this.bindingNavigatorMovePreviousItem.Enabled = (position > 1);
            this.bindingNavigatorMoveNextItem.Enabled = (position < count);
            this.bindingNavigatorMoveLastItem.Enabled = (position < count);
        }

        private void NavigateLeftButton_Click(object sender, EventArgs e)
        {

        }

        private void NavigateRightButton_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("BindingsManager.Position --");
            ++this.BindingManager.Position;
        }

        private void SizeWidthText_TextChanged(object sender, EventArgs e)
        { 
        }

        private void SizeHeightText_TextChanged(object sender, EventArgs e)
        {
        }

        private void LocationXText_TextAlignChanged(object sender, EventArgs e)
        {
        }

        private void LocationYText_TextChanged(object sender, EventArgs e)
        {
        }

        private void ShapeDialog_Load(object sender, EventArgs e)
        {

            this.OKButton.PerformClick();
            //apply(this, EventArgs.Empty);
        }

        private void ShapeDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.document.Shapes.ElementAt(BindingManager.Position).isHighlighted(false);
            this.OKButton.PerformClick();

        }
    }
}

