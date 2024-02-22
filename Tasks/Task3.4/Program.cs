using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;
            
            if (number == 0 || number == 1)
            {
                fact = 1;
            }
            else
            {
                int[] digits = new int[number];
                digits[0] = number;
                for (int i = 1; i < number; i++)
                {
                    digits[i] = digits[i-1] - 1;
                }

                foreach (int i in digits)
                {
                    fact *= i;
                }
            }
            Console.WriteLine($"!{number} = {fact}");
            Console.ReadLine();

        }
    }
}
