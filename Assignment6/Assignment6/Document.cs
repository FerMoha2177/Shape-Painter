using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    [Serializable]
    public class Document
    {
        private Shape shape = new Shape();
        private Shape shapeToEdit;
        private List<Shape> shapes = new List<Shape>();
        private List<Shape> foundShapes = new List<Shape>();

        public List<Shape> Shapes 
        {
            get { return shapes; } 
            set { shapes = value; }
        
        }//come back to this(interface?)

        public Shape Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        //This might not be needed but im leaving it just in case it finds some use
        public Shape ShapeToEdit
        {
            get { return shapeToEdit; }
            set 
            {
                if (shapeToEdit != null)
                {
                    shapeToEdit.IsSelected = false;
                }
                shapeToEdit = value;
                shapeToEdit.IsSelected = true;  
            }
        }

        public void addShape(Shape shape)
        {
            shapes.Add(shape);
            Console.WriteLine("Document.cs: number of Shapes = " + shapes.Count.ToString());
        }

        public void removeShape(Shape shape)
        {
            shapes.Remove(shape);
        }

        public Shape getShape(int index)
        {
            return Shapes.ElementAt(index);
        }

        public void editShape()
        {

        }

        public List<Shape> getShapesUnderPoint(Point clickPoint)
        {
            foundShapes.Clear();

            foreach (Shape s in Shapes)
            {
                if (s.ShapeArea.Contains(clickPoint))
                {
                    foundShapes.Add(s);
                }
            }

            if (foundShapes.Count > 0)
            {
                ShapeToEdit = foundShapes.Last<Shape>();
                ShapeToEdit.IsSelected = true;
            }
            
            return foundShapes;
        }

        //For debugging purposes
        public void DisplayShapeProperties(Shape s)
        {
            Console.WriteLine("New Shape Properties:");
            Console.WriteLine("\t" + s.TypeOfShape);
            Console.WriteLine("\tLocation: " + s.ShapeLocation);
            Console.WriteLine("\tSize: " + s.ShapeSize);
            Console.WriteLine("\t" + s.Brush + "\t" + s.BrushColor);
            //Console.WriteLine("\t" + s.BrushColor);
            Console.WriteLine("\t" + s.Pen + "\t" + s.PenColor);
            //Console.WriteLine("\t" + s.PenColor);
        }




    }
}
