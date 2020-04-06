using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    interface IAppDetails

    {



        /*
          static BrushType TypeOfBrush
        {
            get { return typeOfBrush; }
            set { typeOfBrush = value; }
        }
        */

        Brush Brush
        {
            get;
            set;
        }

          Color BrushColor
        {
            get;
            set;
        }

          Pen Pen
        {
            get;
            set;
        }

         Color PenColor
        {
            get;
            set;
        }


    }
}
