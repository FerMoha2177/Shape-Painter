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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment6
{
    [Serializable]
    public partial class MainForm : BaseForm, IWindowMenu, IAppDetails
    {
        //Things that belong to user interface
        bool mousePressed = false;
        Point mouseDownPos;
        Size realSize;

        Shape shape = new Shape();
        Document document = new Document();
        //ShapeDialog shapeDialog = new ShapeDialog();

        //Color for pen and brush
        Color penColor;
        Color brushColor;
        Brush brush;
        Pen pen;

        static int formCount = 0;
        string fileName;

        private Document doc = new Document();
        private String currentPath = String.Empty;

        //Properties
        public string FileName { get { return this.fileName; } set { this.fileName = value; } }
        public Color PenColor { get { return shape.PenColor; } set { shape.PenColor = value; } } //should be in interface
        public Color BrushColor { get { return shape.BrushColor; } set { shape.BrushColor = value; } }
        public Brush Brush { get { return shape.Brush; } set { shape.Brush = value; } }
        public Pen Pen { get { return shape.Pen; } set { shape.Pen = value; } }
        public Document Document { get { return this.document; } set { this.document = value; } }
       // public ShapeDialog ShapeDialog{ get { return shapeDialog; } set { shapeDialog = value; } }
        public ToolStripMenuItem WindowToolStripMenuItem { get { return this.windowToolStripMenuItem; } } //IWindowMenuInterface
        public Shape Shape { get { return shape; } set { shape = value; } }

        public MainForm()
        {
            InitializeComponent();

            ++formCount;
            this.Text += ": " + formCount.ToString();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true; //This keeps all the shapes from flickering 

            // Add new top-level form to the application context
            MultiSDIApplication.Application.AddMainForm(this);
            ToolStripManager.Merge(this.BaseStrip, this.mainMenuStrip);
        }

        //To support Multi-SDI implementation
        public static MainForm CreateTopLevelWindow(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (MainForm openForm in Application.OpenForms)
                {
                    if (string.Compare(openForm.FileName, fileName, true) == 0)
                    {
                        //Form is already open, bring it to the top
                        openForm.Activate();
                        return openForm;
                    }
                }
            }

            //create new top-level form and open file 
            MainForm form = new MainForm();
            form.OpenFile(fileName); //TO-DO
            form.Show();
            form.Activate();
            return form;
        }

        //TO-DO **made a openfile dialog at the bottom still keeping this 
        void OpenFile(string fileName)
        {
            //this.SaveToolStripMenuItem.Enabled = true;

            if (!string.IsNullOrEmpty(fileName))
            {
                Deserialize(fileName);
            }

            else this.FileName = "Untitled" + formCount.ToString();
            this.Text = this.Text + " (" + this.FileName + ")";
        }

        public override void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean exists = false;

            foreach (Form form in this.OwnedForms)
            {

                if (form is OathDialog)
                    exists = true;


            }

            if (!exists)
            {

                OathDialog oath = new OathDialog();
                oath.Show(this);

            }

        }

        public override void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean exists = false;

            foreach(Form form in this.OwnedForms)
            {

                if (form is AboutDialog)
                    exists = true;


            }

            if (!exists)
            {

                AboutDialog abt = new AboutDialog();
                abt.Show(this);

            }

        }

        public void Serialize(string fileName)
        {

            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, document);
            }
        }

        public void Deserialize(string fileName)
        {

            Document newDoc = new Document();
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                this.currentPath = (fileName);

                IFormatter formatter = new BinaryFormatter();

                if (stream.Length != 0)
                {
                    //if stream is not empty, Serialize
                   this.document = formatter.Deserialize(stream) as Document;

                    foreach(Shape shape in document.Shapes){

                        shape.Init();

                    }
                   this.Invalidate(true);
                }
                else
                {
                    MessageBox.Show("Stream is empty. Fill the Display!");
                }
                
            }

        }

        //Saving, Filters File Extensions
        private void SaveAs()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Paint Files (*.pnt)|*.pnt";
                dlg.DefaultExt = "pnt";
                dlg.AddExtension = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    currentPath = dlg.FileName;
                    Serialize(dlg.FileName);
                }
            }

            //this.SaveToolStripMenuItem.Enabled = true;
        }

        private void Save()
        {
            Serialize(currentPath);
        }


        // MOUSE HANDLERS FOR DRAWING SHAPES VIA DRAGGING
        //Set the starting location of the shape and set mousePressed until the button is released
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine("MouseDown on MainForm: " + MousePosition);
                mousePressed = true;
                mouseDownPos = e.Location;
                shape.ShapeLocation = mouseDownPos;
            }
        }

        //Calculate ShapeSize and ShapeLocation as a function of the mouse being dragged from the origin point
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            //MouseMove only matters when the mouse is pressed
            if (mousePressed)
            {
                //Capture "Real" size to determine if shape location should be altered depending on where the user dragged
                realSize = new Size(e.Location.X - mouseDownPos.X, e.Location.Y - mouseDownPos.Y);

                //ShapeSize is always in positive values
                shape.ShapeSize = new Size(
                    Math.Abs(e.Location.X - mouseDownPos.X), //Width
                    Math.Abs(e.Location.Y - mouseDownPos.Y));//Height

                // mouseDownPos is the origin point
                if (realSize.Width < 0)
                {
                    if (realSize.Height < 0)                   
                    {
                        shape.ShapeLocation = e.Location; // Flip ShapeLocation over the Y and X axis
                    }
                    else 
                    {
                        shape.ShapeLocation = new Point(e.Location.X, mouseDownPos.Y); //Flip ShapeLocation over the Y axis
                    }
                }
                else if (realSize.Height < 0)
                {
                    shape.ShapeLocation = new Point(mouseDownPos.X, e.Location.Y); //Flip ShapeLocation over the X axis 
                }
                Invalidate(true);
            }
        }

        //When the left mouse button is realeased, the shape is finished
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine("MouseUp on MainForm: " + MousePosition);
                Console.WriteLine("ShapeSize: " + shape.ShapeSize);

                mousePressed = false;

                //Dont draw or add shapes that cant be seen or clicked on
                if (shape.ShapeSize.Width > 0 && shape.ShapeSize.Height > 0)
                {
                    FinishShape(e);
                }

                //Reset the shape size to 0 so you don't see the same shape on next MouseDown
                shape.ShapeSize = new Size(0, 0);
            }
        }

        private void FinishShape(MouseEventArgs e)
        {
            //Instantiate a new Shape object to add to the document
            Shape s = new Shape();

            //Copy shape properties into new Shape object
            s.ShapeLocation = shape.ShapeLocation;
            s.ShapeSize = shape.ShapeSize;
            s.TypeOfShape = shape.TypeOfShape;
            s.TypeOfBrush = shape.TypeOfBrush;
            s.BrushColor = shape.BrushColor;
            s.Brush = shape.Brush;
            s.PenColor = shape.PenColor;

                s.setBrush(Shape.TypeOfBrush);
            
            s.Pen = shape.Pen;

            DisplayShapeProperties(s);
            Document.addShape(s);
            Invalidate(true);
        }

        //For debugging purposes
        private void DisplayShapeProperties(Shape s)
        {
            Console.WriteLine("New Shape Properties:");
            Console.WriteLine("\t" + s.TypeOfShape);
            Console.WriteLine("\t" + s.ShapeLocation);
            Console.WriteLine("\t" + s.ShapeSize);
            Console.WriteLine("\t" + s.Brush);
            Console.WriteLine("\t" + s.BrushColor);
            Console.WriteLine("\t" + s.Pen);
            Console.WriteLine("\t" + s.PenColor);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //Paint all shapes contained in Document Class
            foreach (Shape s in document.Shapes)
            {
                RenderShape(s, e);
            }

            RenderShape(shape, e);  //Renders the shape held by main form seperate from those stored in document
        }

        private void RenderShape(Shape s, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(s.ShapeLocation.X, s.ShapeLocation.Y, s.ShapeSize.Width, s.ShapeSize.Height);

            Point[] triangle = new Point[] {
                new Point(s.ShapeLocationX, s.ShapeLocation.Y + s.ShapeHeight),
                new Point(s.ShapeLocationX + s.ShapeSize.Width/2, s.ShapeLocationY),
                new Point(s.ShapeLocationX + s.ShapeWidth, s.ShapeLocationY + s.ShapeHeight) };

            Graphics g = e.Graphics;
            GraphicsPath path = new GraphicsPath();

            //Add one for the custom shape
            if (s.TypeOfShape == Shape.ShapeType.Ellipse)
            {
                path.AddEllipse(rect);
            }
            else if (s.TypeOfShape == Shape.ShapeType.Rectangle)
            {
                path.AddRectangle(rect);
            }
            else
            {
                g.FillPolygon(s.Brush, triangle);
                g.DrawPolygon(s.Pen, triangle);
                return;
            }

            g.FillPath(s.Brush, path);
            g.DrawPath(s.Pen, path);
        }

        //Right-click to edit shape(s)
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                List<Shape> foundShapes = Document.getShapesUnderPoint(e.Location);
                Console.WriteLine("Number of Shapes found: " + foundShapes.Count);

                if (foundShapes.Count > 0)
                {      
                    ShapeDialog ShapeDialog = new ShapeDialog(this.document, document.Shapes.IndexOf(foundShapes.ElementAt(0)));
                    ShapeDialog.apply += new EventHandler(this.apply_Click);
                    ShapeDialog.Show();
                }
            }
        }

        private void checkOnly(ToolStripMenuItem parent, ToolStripMenuItem child)
        {
            if (!child.Checked)
            {
                child.Checked = true;
            }

            if (child.Checked)
            {
                foreach (ToolStripMenuItem item in parent.DropDownItems)
                {
                    if (item != child)
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        //TODO: Add Menu Click Events

        //Wont work until Document Class is done
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        //Wont work until Document Class is done
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        //Opening File with Filtered Extensions
        //Wont Work Properly until Document Class is Done
        private void OpenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Paint Files|*.pnt*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Deserialize(dlg.FileName);
                }
            }

            //this.SaveToolStripMenuItem.Enabled = true;
        }

        //Color Menu
        private void PenColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColorDialog penColordlg = new ColorDialog();

            if (penColordlg.ShowDialog() == DialogResult.OK)
            {
                shape.PenColor = penColordlg.Color;
            }
        }

        private void BrushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog brushColordlg = new ColorDialog();

            if (brushColordlg.ShowDialog() == DialogResult.OK)
            {
                shape.BrushColor = brushColordlg.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.CreateTopLevelWindow(null);
        }

        private void solidBrushMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(brushMenuItem, solidBrushMenuItem);
            shape.TypeOfBrush = (Shape.BrushType.Solid);
            Console.WriteLine(shape.TypeOfBrush);
        }

        private void hatchBrushMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(brushMenuItem, hatchBrushMenuItem);
            shape.TypeOfBrush = (Shape.BrushType.Hatched);
        }

        private void linearGradientBrushMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(brushMenuItem, linearGradientBrushMenuItem);
            shape.TypeOfBrush = (Shape.BrushType.LinearGradient);
        }

        private void solidPenMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(penMenuItem, solidPenMenuItem);
            shape.TypeOfPen = (Shape.PenType.Solid);
        }

        private void customDashedPenMenuItem_Click(object sender, EventArgs ev)
        {
            checkOnly(penMenuItem, customDashedPenMenuItem);
            shape.TypeOfPen = (Shape.PenType.Dashed);
        }

        private void compoundPenMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(penMenuItem, compoundPenMenuItem);
            shape.TypeOfPen = Shape.PenType.Compound;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(shapeMenuItem, ellipseToolStripMenuItem);
            shape.TypeOfShape = Shape.ShapeType.Ellipse;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(shapeMenuItem, rectangleToolStripMenuItem);
            shape.TypeOfShape = Shape.ShapeType.Rectangle;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkOnly(shapeMenuItem, customToolStripMenuItem);
            shape.TypeOfShape = Shape.ShapeType.Custom;
        }

        //New File Button, Complained when i tried to change the name
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void BrushTypeSplitBtn_ButtonClick(object sender, EventArgs e)
        {
            //do nothing
        }

        private void PenColorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Pen color toolstrip
            PenColorToolStripMenuItem_Click_1(sender, e);
        }

        private void BrushColorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //brush color toolstrip
            BrushColorToolStripMenuItem_Click(sender, e);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenToolStripMenuItem_Click_1(sender, e);
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (currentPath == String.Empty)
            {
                SaveAs();
            }
            else
            {
                Save();
            }
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            rectangleToolStripMenuItem_Click(sender, e);
        }

        private void OvalButton_Click(object sender, EventArgs e)
        {
            ellipseToolStripMenuItem_Click(sender, e);
        }

        private void CustomShapeBtn_Click(object sender, EventArgs e)
        {
            customToolStripMenuItem_Click(sender, e);
        }

        private void SolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pen Solid
            solidPenMenuItem_Click(sender, e);
        }

        private void CustomDashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customDashedPenMenuItem_Click(sender, e);
        }

        private void CompoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compoundPenMenuItem_Click(sender, e);
        }

        private void SolidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //brush solid
            solidBrushMenuItem_Click(sender, e);
        }

        private void HatchedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hatchBrushMenuItem_Click(sender, e);
        }

        private void LinearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linearGradientBrushMenuItem_Click(sender, e);
        }

        private void ShapeOptionsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ShapeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.ShapeDialog.Close(); //I'll get to this
        }

        private void apply_Click(object sender, EventArgs e)
        {

            this.Invalidate(true);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.solidPenMenuItem.PerformClick();
            this.solidBrushMenuItem.PerformClick();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentPath == string.Empty)
            {
                saveToolStripMenuItem.Enabled = false;
            }
            else
            {
                saveToolStripMenuItem.Enabled = true;
            }
        }
    }
}
