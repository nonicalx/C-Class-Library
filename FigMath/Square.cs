using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigMath
{
    public class Square
    {
        public double GetArea(double width)
        {
            double area = width * width;
            return area;
        }

        public double GetPerimeter(double width)
        {
            double periemeter = 4 * width;
            return periemeter;
        }

        public double GetEqCubeArea(double width)
        {
            double areaOfEqCube = GetArea(width) * 6;
            return areaOfEqCube;
        }
    }

    
}
