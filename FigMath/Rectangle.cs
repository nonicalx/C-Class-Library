using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigMath
{
    public class Rectangle
    {
        public double GetArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
        public double GetPerimeter(double width, double height)
        {
            double periemeter = (2 * width) + (2 * height);
            return periemeter;
        }
    }
}
