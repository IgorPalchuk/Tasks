using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctLogin = "johnsilver";
            string correctPassword = "qwerty";

            

            int counter = 0;
            while(counter < 3)
            {
                Console.Write("Write a login: ");
                string login = Console.ReadLine();

                Console.Write("Write a password: ");
                string password = Console.ReadLine();

                if (login.Equals(correctLogin) && password.Equals(correctPassword))
                {
                    Console.WriteLine("Enter the System");
                    break;
                }
                else
                {
                    counter++;
                }

            }
            if (counter == 3)
            { 
                Console.WriteLine("The number of available tries have been exceeded");
            }
            Console.ReadLine();

        }
    }
}
