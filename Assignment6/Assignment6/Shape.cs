using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment6
{
    [Serializable]
    public class Shape
    {
        private Size defaultSize = new Size(0, 0);
        private Point defaultLocation = new Point(100, 100);

        public event PropertyChangedEventHandler PropertyChanged;

        private Size shapeSize;
        private Point shapeLocation;
        private ShapeType typeOfShape;
        private Color brushColor = Color.Blue; //Default Color
        private BrushType typeOfBrush;
        private PenType typeOfPen;
        [NonSerialized]
        private Brush brush; //= new SolidBrush(BrushColor);
        private Color penColor = Color.Black;
        [NonSerialized]
        private Pen pen; //= new Pen(Brush);
        private Rectangle shapeArea;

        private bool isSelected = false;

        private static float[] compoundNumbers = { 0.0F, 0.2F, 0.3F, 0.45F, 0.55F, 0.7F, 0.8F, 1.0F };

        //static Color PenColor { get; set; }
        //static Color BrushColor { get; set; }
        //public static PenType TypeOfPen { get; set; }
        //public static BrushType typeOfBrush;

        public Shape()
        {
            //Initialize New Shape 
            ShapeSize = new Size(0, 0);
            ShapeLocation = new Point(0, 0);
            TypeOfShape = ShapeType.Rectangle;
            TypeOfBrush = BrushType.Solid;
            Brush = new SolidBrush(BrushColor);
            Pen = new Pen(penColor);
        }

        public Size ShapeSize
        {
            get { return shapeSize; }
            set { shapeSize = value; }
        }

        public int ShapeWidth
        {
            get { return shapeSize.Width; }
            set { shapeSize.Width = value; }
        }

        public int ShapeHeight
        {
            get { return shapeSize.Height; }
            set { shapeSize.Height = value; }
        }

        public Point ShapeLocation
        {
            get { return shapeLocation; }
            set { shapeLocation = value; }
        }

        public int ShapeLocationX
        {
            get { return shapeLocation.X; }
            set { shapeLocation.X = value; }
        }

        public int ShapeLocationY
        {
            get { return shapeLocation.Y; }
            set { shapeLocation.Y = value; }
        }

        public ShapeType TypeOfShape
        {
            get { return typeOfShape; }
            set { this.typeOfShape = value; }
        }

        public PenType TypeOfPen
        {
            get { return typeOfPen; }
            set { typeOfPen = value; UpdatePen(); }
        }

        public Rectangle ShapeArea
        {
            get { return new Rectangle(ShapeLocation, ShapeSize); }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }


        public BrushType TypeOfBrush
        {
            get { return typeOfBrush; }
            set { typeOfBrush = value; UpdateBrush(); }
        }

        public Brush Brush
        {
            get { return brush; }
            set { this.brush = value; }
        }

        public Color BrushColor
        {
            get { return brushColor; }
            set { brushColor = value; UpdateBrush(); }
        }

        public Pen Pen
        { get { return pen; } set { pen = value; } }

        public Color PenColor
        {
            get { return penColor; }
            set { this.penColor = value; UpdatePen(); }
        }

        public Color getBrushColor()
        {
            return BrushColor;
        }

        public void UpdateBrush()
        {
            setBrush(typeOfBrush);
            //Brush = new SolidBrush(BrushColor);
        }

        public void UpdatePen()
        {
            Pen = new Pen(penColor);
            setPenType(this.TypeOfPen);

        }

        public void UpdatePen(Color penColor) //override for highlighting 
        {
            Pen = new Pen(penColor);
            setPenType(this.TypeOfPen);

        }

        public void setPenType(PenType penType)
        {
            switch (penType)
            {
                case PenType.Dashed:
                    this.Pen.DashStyle = DashStyle.Dash;
                    break;
                case PenType.Compound:
                    this.Pen.CompoundArray = compoundNumbers;
                    break;
                default:
                    this.Pen.DashStyle = DashStyle.Solid;
                    break;
            }
        }

        public void setBrush(BrushType brushType)
        {
            switch (brushType)
            {
                case BrushType.LinearGradient:
                    this.Brush = new LinearGradientBrush(new Point(0, 0), new Point(100, 100), BrushColor, Color.Black);
                    Console.WriteLine("\tBrush set to LinearGradient");
                    break;
                case BrushType.Hatched:
                    this.Brush = new HatchBrush(HatchStyle.Cross, BrushColor);
                    Console.WriteLine("\tBrush set to HatchBrush");

                    break;
                default:
                    this.Brush = new SolidBrush(BrushColor);
                    Console.WriteLine("\tBrush set to SolidBrush");

                    break;
            }
        }

        public enum ShapeType
        {
            Ellipse = 0,
            Rectangle = 1,
            Custom = 2
        }

        public enum PenType
        {
            Solid = 0,
            Dashed = 1,
            Compound = 2
        }

        public enum BrushType
        {
            LinearGradient = 0,
            Solid = 1,
            Hatched = 2 //maybe more
        }

        public void isHighlighted(Boolean highlighted)
        {

            //this could cause issues

            if (highlighted)
            {

                this.Brush = new LinearGradientBrush(new Point(0, 0), new Point(100, 100), BrushColor, Color.White);

            }
            else
            {

                UpdateBrush();
                //this.Pen.EndCap = LineCap.Flat;

            }



        }

        public void Init()
        {

            UpdateBrush();
            UpdatePen();

        }
    }

}
