using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.a);
            Constants constants = new Constants(20);
            Console.WriteLine(constants.c);
            object d = constants.b;
            Console.WriteLine(d);
            int k = (int)d;
            Console.WriteLine(k);

            Console.WriteLine();

            Console.WriteLine(New.a);
            New dfd = new New(10);
            object l = dfd.b;
            Console.WriteLine(l);
            int p = (int)l;
            Console.WriteLine(p);

            Console.WriteLine();

            Constants1<string> constants1 = new Constants1<string> ( "Alo" );
            object alo = Constants1<int>.a;
            Console.WriteLine(alo);
            int alo1 = (int)alo;
            Console.WriteLine(alo1);



        }
    }
}
