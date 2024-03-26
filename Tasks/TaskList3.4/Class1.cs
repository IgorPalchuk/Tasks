using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._4
{
    public interface IPerimeterFigure
    {
        
        double GetPerimeter();
    }
    public interface ISquareFigure
    {
        double GetSquare();
        
    }
    public class Circles : ISquareFigure, IPerimeterFigure
    {
        public double R { get; set; }
        public Circles(double r)
        {
            this.R = r;
        }
        

        public double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
    }
    public class Triangles : ISquareFigure, IPerimeterFigure
    {
        public double H { get; set; }
        public double Ab { get; set; }
        public Triangles(double h, double ab)
        {
            this.H = h;
            this.Ab = ab;
        }

        public double GetSquare()
        {
            return (H * Ab) / 2;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
    public class Rectangles : ISquareFigure, IPerimeterFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public Rectangles(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double GetSquare()
        {
            return A * B;
        }

        public double GetPerimeter()
        {
            return (A + B) * 2;
        }
    }

}
