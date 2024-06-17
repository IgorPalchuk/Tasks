using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewTaskList2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 18;

            Task<int> fiboTask =  Task.Run(() => Fibo(number));


            fiboTask.Wait();

            int result = fiboTask.Result;

            Console.WriteLine(result);
            





        }
        static int Fibo(int amount)
        {
            if (amount <= 1)
            {
                return 1;
            }
            else
            {
                return Fibo(amount - 1) + Fibo(amount - 2);
            }
        }
    }
}
