using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayersFromUSA.AllPlayersFromUSA(@"D:\Tasks\Tasks\Task9.2\Top100ChessPlayers.xlsx");

            Console.ReadLine();
        }
       
    }
}
