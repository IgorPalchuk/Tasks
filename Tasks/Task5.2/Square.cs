using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    internal class Square
    {
        
        public double CalcTriangleSquare( double x, double y, int z)
        {
            double rads = z * Math.PI / 180;
            return 0.5 * x * y * Math.Sin(rads);
        }
        public double CalcTriangleSquare(double ac, double bc, double ab)
        {
            double p = (ac + ab + bc) / 2;

            return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
        }
        public double CalcTriangleSquare(double h, double b)
        {
            return 0.5 * b * h;
        }
    }
}
