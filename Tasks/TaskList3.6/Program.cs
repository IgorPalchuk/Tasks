using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(2, 3);
            Vector vector2 = new Vector(3, 4);
            Vector vector3 = new Vector(2, 3);
            Vector plus = vector1 + vector2;
            Console.WriteLine(plus);
            Vector minus = vector1 - vector2;
            Console.WriteLine(minus);
           

            bool equals = vector1.Equals(vector2);
            Console.WriteLine(equals);

            bool equals2 = vector1.Equals(vector3);
            Console.WriteLine(equals2);
        }
    }
}
