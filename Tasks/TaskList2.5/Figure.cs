using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList2._5
{
    public abstract class Figure
    {

        public abstract double Square();
        
    }
    public class Rectangle : Figure
    {
        public double x {  get; set; }
        public double y { get; set; }
        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;    
        }


        public override double Square()
        {
            return x * y;
        }
    }
    public class Triangle : Figure
    {
        public double X { get; set; }
        public double H { get; set; }
        public Triangle(double x, double h)
        {
            this.H = h;
            this.X = x;
        }
        public double ab { get; set; }
        public double bc { get; set; }
        public double ac { get; set; }
        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
        }
        public override double Square()
        {
           double s = (ab + bc + ac) / 2;
           return Math.Sqrt(s * (s - ab) * s * (s - bc) * s * (s - ac));
        }
        public  double Square(double x, double h)
        {
            return (X * H) / 2;
        }
    }
    public class Circle : Figure
    {
        public double x { get; set; }
        public Circle(double x)
        {
            this.x = x;
        }
        public override double Square()
        {
            return Math.PI * Math.Pow(x,2);
        }
    }
}
