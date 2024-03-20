using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._2
{
    public enum Players
    {
        Human,
        Computer
    }
    public class Guess
    {
        private readonly int max = 100;
        private readonly int maxTries = 5;
        private readonly Players player;
        public Guess(int max = 100, int maxTries = 5, Players player = Players.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
            this.player = player;

        }

        public void Start()
        {
            if(player == Players.Human)
            {
                HumanGuesses();
            }
            else
            {
                ComputerGuesses();
            }
        }

        private void HumanGuesses()
        {
            Random random = new Random();
            int number = random.Next(0,max);
            int count = 0;
            int guessing = -1;

            while(guessing != number && count < maxTries)
            {
                Console.WriteLine("Guess the number");
                try
                {
                    guessing = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if(guessing == number)
                {
                    Console.WriteLine("You win");
                }
                else if(guessing > number)
                {
                    Console.WriteLine("Your number is bigger");
                }
                else if(guessing < number)
                {
                    Console.WriteLine("Your number is smaller");
                }

                count++;

                if (count == maxTries)
                {
                    Console.WriteLine("You lost");
                }

                
            }
        }

        private void ComputerGuesses()
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            int guessing = -1;
            int max = 100;
            int min = 0;
            int count = 0;
            while(guessing != number && count < maxTries)
            {
                guessing = (max + min) / 2;
                Console.WriteLine($"{guessing}?");
                if (guessing == number)
                {
                    Console.WriteLine("Computer wins");
                }
                else
                {
                    Console.WriteLine("Choose:\n" +"1.My number is bigger\n"+"2.My number is smaller");
                    int choose = int.Parse(Console.ReadLine());

                    switch (choose)
                    {
                            case 1:
                            min = guessing;
                            break;
                            case 2:
                            max = guessing;
                            break;

                    }

                }
                count++;

                if (count == maxTries)
                {
                    Console.WriteLine("Computer lost");
                }
            }
        }
        
    }
}
