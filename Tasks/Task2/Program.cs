using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a first whole number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Write a second whole number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First number: {firstNumber} \nSecond number: {secondNumber} ");

            int a = firstNumber;
            firstNumber = secondNumber;
            secondNumber = a;

            Console.WriteLine($"First number: {firstNumber} \nSecond number: {secondNumber} ");

            Console.ReadLine();


        }
    }
}
