using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewTaskList2._4
{
    internal class Program
    {
        static int count = 0;
        static object locker = new object();    
        static void Main(string[] args)
        {
           
            Thread myThread = new Thread(Counter);
            Thread myThread1 = new Thread(Counter);

            myThread.Start();
            myThread1.Start();

            myThread.Join();
            myThread1.Join();

            Console.WriteLine(count);


        }
         static void Counter()
        {
            for(int i = 0; i < 10; i++)
            {
                lock(locker)
                {
                    count++;
                }
                
            }
            
        }
    }
}
