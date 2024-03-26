using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._4.Hangman
{
    public class HangmanGame
    {
        private readonly int allowedMisses;
        private bool[] openIndexes;
        private int triesCounter = 0;
        private string triedLetters;

        public GameStatus GameStatus { get; set; } = GameStatus.NotStarted;
        public string Word { get; private set; }

        public string TriedLetters
        {
            get
            {
                var chars = triedLetters.ToCharArray();
                Array.Sort(chars);
                return new string(chars);

            }
        }

        public int RemainingTries
        {
            get
            {
                return allowedMisses - triesCounter;
            }
        }
        public HangmanGame(int allowedMisses = 6)
        {
            if (allowedMisses < 5 || allowedMisses > 8)
                throw new ArgumentException("Wrong number of allowed misses");

            this.allowedMisses = allowedMisses;
        }
        public string GenerateWord()
        {
            string[] words = File.ReadAllLines("Hangman\\WordsStock.txt");  
            Random r = new Random();
            int index = r.Next(words.Length-1);
            Word = words[index];

            openIndexes = new bool[words.Length];

            GameStatus = GameStatus.InProgress;

            return Word;
        }
        public string GuessLetter(char letter)
        {
            if(triesCounter == allowedMisses)
            {
                throw new IOException("");
            }
            if(GameStatus != GameStatus.InProgress) 
            {
                throw new IOException("");
            }

            bool openAny = false;

            string result = "";
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    openAny = true;
                    openIndexes[i] = true;
                }

                if (openIndexes[i])
                {
                    result += Word[i];
                }
                else
                {
                    result += "-";
                }
            }
                if (!openAny)
                {
                    triesCounter++;
                }

                triedLetters += letter;

                if (isWin())
                {
                    GameStatus = GameStatus.Won;
                }
                else if (triesCounter == allowedMisses)
                    GameStatus = GameStatus.Lost;

            
            return result;
        }
        
        private bool isWin()
        {
            foreach (var i in openIndexes)
            {
                if (i == true)
                {
                    return false;

                }
            }
                return true;
            }
        }
    }

