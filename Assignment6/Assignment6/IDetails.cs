using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    interface IDetails
    {
        //Not too sure if this is what he meant by "Implemenentaion Details" I thought of form properties and the shape/brush properties maybe??

        List<Shape> shapes
        {
            get;
            set;
        }
        Size FormSize
        {
            get;
            set;
        }

        Point FormLocation
        {
            get;
            set;
        }

        String Title
        {
            get;
            set;
        }

        Size ShapeSize
        {
            get; set;

        }
        Point ShapeLocation
        {
            get; set;
        }
        Color PenColor
        {
            get; set;
        }
        Color BrushColor
        {
            get; set;
        }












    }
}
