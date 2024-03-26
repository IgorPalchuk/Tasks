using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var figure = new Rectangle(10,5);
            
            Console.WriteLine(figure.CalculateSquare());

            ISquareFigure[] squareFigures = new ISquareFigure[] { new Triangles(10, 5), new Rectangles(12, 8), new Circles(5) };
            foreach (var squareFigure in squareFigures)
            {
                Console.WriteLine(squareFigure.GetSquare());
            }
        }
    }
}
