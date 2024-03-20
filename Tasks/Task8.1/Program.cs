using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 1);
            Complex c2 = new Complex(1, 2);

            Complex result = c1.Plus(c2);
            Complex result2 = c2.Minus(c1);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
