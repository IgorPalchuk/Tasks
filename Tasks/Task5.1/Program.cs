using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word from these");
            foreach(var i in Parsing.map)
                Console.WriteLine(i);
            Console.WriteLine (Parsing.Parse(Console.ReadLine()));
           
            Console.ReadLine();
        }
    }
}
