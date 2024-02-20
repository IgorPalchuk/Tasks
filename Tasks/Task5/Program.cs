using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Your first name: ");
            string name = Console.ReadLine();

            Console.Write("Your age: ");
            double age = double.Parse(Console.ReadLine());

            Console.Write("Your weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Your height(in meters): ");
            double height = double.Parse(Console.ReadLine());

            double index = weight / (height * height);

            Console.WriteLine($"Your profile:\n"
                + $"Full Name: {surname},{name}\n" 
                + $"Age: {age}\n" 
                + $"Weight: {weight}\n" 
                + $"Height: {height}\n" 
                + $"Body Mass Index: {index}");

            Console.ReadLine();




        }
    }
}
