using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTaskList2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ii = 1000000;
            int[] numbers = new int[ii];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1,9);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long sequentialSum = SequentialSum(numbers);
            stopwatch.Stop();
            Console.WriteLine($"SequentialSum: {sequentialSum}");
            Console.WriteLine($"SequentialSum:{stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            long parallelSum = ParallelSum(numbers);
            stopwatch.Stop();
            Console.WriteLine($"ParallelSum: {parallelSum}");
            Console.WriteLine($"ParallelSum:{stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            long parallelForEachSum = ParallelForEachSum(numbers);
            stopwatch.Stop();
            Console.WriteLine($"ParallelForEachSum: {parallelForEachSum}");
            Console.WriteLine($"ParallelForEachSum:{stopwatch.ElapsedMilliseconds}");



        }
        static long SequentialSum(int[] numbers)
        {
            long sum = 0;
            for(int i  = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static long ParallelSum(int[] numbers)
        {
            long sum = 0;
            object locker = new object();

            Parallel.For(0, numbers.Length, () => 0L, (i,loopState, localSum ) =>
            {
                localSum += numbers[i];
                return localSum;
            }, localSum =>
            {
                lock( locker )
                {
                    sum += localSum;
                }
            });
            return sum;
        }
        static long ParallelForEachSum(int[] numbers)
        {
            long sum = 0;
            object locker = new object();
            Parallel.ForEach(numbers, x =>
            {
                lock ( locker )
                {
                    sum += x; 
                }
                
            });
            return sum;
        }
    }
}
