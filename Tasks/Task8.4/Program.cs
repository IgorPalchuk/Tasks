using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8._4.Hangman;

namespace Task8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();
            string word = game.GenerateWord();

            Console.WriteLine($"The word consists of : {word.Length} letters");
            Console.WriteLine("Try to guess the word");

            while(game.GameStatus == GameStatus.InProgress)
            {
                Console.WriteLine("Pick the letter:");
                char letter = Console.ReadLine().ToCharArray()[0];

                string curState = game.GuessLetter(letter);
                Console.WriteLine(curState);

                Console.WriteLine($"Remaining tries = {game.RemainingTries}");
                Console.WriteLine($"Tried letters: {game.TriedLetters}");

            }
            if(game.GameStatus == GameStatus.Lost)
            {
                Console.WriteLine("You  lost");
                Console.WriteLine($"Word was: {game.Word}");
            }
            else if(game.GameStatus == GameStatus.Won) 
            {
                Console.WriteLine("You won");
            }
        }
    }
}
