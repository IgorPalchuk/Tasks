using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewTaskList2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            var token = cts.Token;

            Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Iteration №{i}");
                    token.ThrowIfCancellationRequested();
                }
            },token);

            Thread.Sleep(5000);
            Console.WriteLine("Cancel is requested");
            cts.Cancel();


        }
    }
}
