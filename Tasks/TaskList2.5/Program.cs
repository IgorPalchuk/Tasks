using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var figure = new Rectangle(10,5);
            var fdfd = figure as Figure;

            if (fdfd is Figure )
            {
                Console.WriteLine(fdfd.Square()); 
            }
            else
            {
                Console.WriteLine("Wrong");
            }
             
            var figure2 = new Triangle(5,10);
            

        }
    }
}
