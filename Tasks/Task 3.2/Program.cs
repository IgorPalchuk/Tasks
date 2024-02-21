using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            int numbersCount = int.Parse(Console.ReadLine());

            int numbers = 1;
            int[]fibo = new int[numbersCount];
            fibo[0] = numbers;
            fibo[1] = numbers;
            for(int i = 2; i < numbersCount; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            for(int i = 0;i < fibo.Length; i++)
            {
                Console.WriteLine(fibo[i]);
            }
            Console.ReadLine();


        }
    }
}
