using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigMath
{
    class Triangle
    {
        public double GetArea(double bas, double height)
        {
            double area = (0.5 * bas) * height;
            return area;
        }

        public double GetArea(double aSide,double bSide, double cSide)
        {
            double sPerimeter = 0.5*(aSide + bSide + cSide);
            double temp = (sPerimeter) * (sPerimeter - aSide) * (sPerimeter - bSide)
                * (sPerimeter - cSide);
            double area = Math.Sqrt(temp);
            return area;
        }

        public double GetArea(double sideEquilateralTri)
        {
            double area = (sideEquilateralTri * sideEquilateralTri)
                * ((Math.Sqrt(3)) / 4);
            return area;
        }

        public double GetArea(double a, double b, int angleBtwAB)
        {
            double temp0 = (a * b) / 2;
            double area = temp0 * Math.Sin(angleBtwAB);
            return area;
        }

        public double GetPerimeter(double aSide, double bSide, double cSide)
        {
            double perimeter = aSide + bSide + cSide;
            return perimeter;
        } 
    }
}
