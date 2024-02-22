using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write to 10 positive whole numbers:");
            int[] numbers = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i+1}: ");
                int convert = int.Parse( Console.ReadLine());
                numbers[i] = convert;

                if (convert == 0)
                {
                    break;
                }
               
            }
            Console.ReadLine();
            int sum = 0 ;
            int counter = 0;
            double average = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 3 == 0 && numbers[j] > 0  )
                {
                    sum += numbers[j];
                    counter++;
                }

               
            }
            average = (double)sum / counter;



            Console.WriteLine($"Average: {average}");
            Console.ReadLine();

        }
    }
}
