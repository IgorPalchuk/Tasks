using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._4
{
    public abstract class Figure
    {
        public abstract double CalculateSquare();
        
    }
    public class Circle : Figure
    {
        public double R { get; set; }
        public Circle(double r) 
        {
            this.R = r;
        }
        public override double CalculateSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }

       
    }
    public  class Triangle : Figure 
    {
        public double H { get; set; }
        public double Ab { get; set; }
        public Triangle(double h, double ab)
        {
            this.H = h;
            this.Ab = ab;
        }
        public override double CalculateSquare()
        {
            return (H * Ab) / 2;
        }

        
    }
    public class Rectangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public Rectangle(double a, double b)
        {
            this.A = a;
            this.B = b; 
        }
        public override double CalculateSquare()
        {
            return A * B;
        }

       
    }
}
