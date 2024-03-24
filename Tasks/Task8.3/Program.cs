using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._3
{
    internal class Program
    {
        private static TicTacToe g = new TicTacToe();
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrintableState());
            while(g.GetWinner() == Winner.GameIsUnfinished)
            {
                int index = int.Parse(Console.ReadLine());
                g.MakeMove(index);

                Console.WriteLine();
                Console.WriteLine(GetPrintableState());

            }
            Console.WriteLine($"Result: {g.GetWinner()}");

        }
        static string GetPrintableState()
        {
            var sb = new StringBuilder();
            for(int i = 1; i <= 7; i += 3)
            {
                sb.AppendLine("     |     |     |")
                    .AppendLine(
                    $"  {GetPrintableChar(i)}  |  {GetPrintableChar(i + 1)}  |  {GetPrintableChar(i + 2)}  |")
                    .AppendLine("_____|_____|_____|");
            }
            return sb.ToString();
        }
        static string GetPrintableChar(int index)
        {
            State state = g.GetState(index);
            if(state == State.Cross)
            {
                return "X";
            }
            else if(state == State.Zero)
            {
                return "O";
            }
            return index.ToString();
        }
    }
}
