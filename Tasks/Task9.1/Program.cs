using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new StickGame(10, Player.Human);
            game.MachinePlayed += Game_MachinePlayed;
            game.HumanTurnToMakeMove += Game_HumanTurnToMakeMove;
            game.EndOfGame += Game_EndOfGame;
            game.Start();
        }

        private static void Game_EndOfGame(Player obj)
        {
            Console.WriteLine($"Winner: {obj}");
        }

        private static void Game_HumanTurnToMakeMove(object sender, int remainingSticks)
        {
            Console.WriteLine($"Remaining sticks {remainingSticks} ");
            Console.WriteLine("Take some sticks");

            bool takenCorrectly = false;
            while (!takenCorrectly) 
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    var game = (StickGame)sender;
                    try
                    {
                        game.HumanTakes(result);
                        takenCorrectly = true;
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private static void Game_MachinePlayed(int sticksTaken)
        {
            Console.WriteLine($"Machine took: {sticksTaken}");
        }
    }
}
