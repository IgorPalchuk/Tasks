using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a length of the first side: ");
            double lengthOfFirstSide = double.Parse(Console.ReadLine());

            Console.Write("Write a length of the second side: ");
            double lengthOfSecondSide = double.Parse(Console.ReadLine());

            Console.Write("Write a length of the third side: ");
            double lengthOfThirdSide = double.Parse(Console.ReadLine());

            double p = (lengthOfFirstSide + lengthOfSecondSide+lengthOfThirdSide)/2;

            Console.WriteLine($"Square = {Math.Sqrt(p*(p-lengthOfFirstSide)*(p-lengthOfSecondSide)*(p-lengthOfThirdSide))}");

            Console.ReadLine();
        }
    }
}
