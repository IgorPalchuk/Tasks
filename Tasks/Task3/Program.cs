using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a whole number: ");
            string number = Console.ReadLine();
            int quantity = number.Length;

            Console.Write($"Number of digits: {quantity}");

            Console.ReadLine();


        }
    }
}
