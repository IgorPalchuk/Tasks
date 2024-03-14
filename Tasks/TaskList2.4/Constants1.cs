using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList2._4
{
    public class Constants1<T>
    {
        public const int a = 1;
        public readonly T b;
        public readonly int c = 2;
        public Constants1(T a)
        {
            this.b = a;
            Console.WriteLine(b);
        }
        
    }
}
