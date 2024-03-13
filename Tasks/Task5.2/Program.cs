using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            double square = square1.CalcTriangleSquare(10, 20, 50);
            Console.WriteLine(square);
        }
    }
}
