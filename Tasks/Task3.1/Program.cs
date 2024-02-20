using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write first number:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Write second number:");
            int b = int.Parse(Console.ReadLine());

            string max = a > b ? $"Max: {a}" : $"Max: {b}";

            Console.WriteLine(max);

            Console.ReadLine();

        }
    }
}
