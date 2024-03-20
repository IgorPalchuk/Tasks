using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guess guess = new Guess(100,5,Players.Computer);
            guess.Start();
        }
    }
}
