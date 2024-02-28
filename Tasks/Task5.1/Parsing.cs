using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    internal class Parsing
    {
        public static Dictionary<char, int> map = new Dictionary<char, int>() {

    { 'I' , 1},
    { 'V',  5 },
    { 'X' , 10 },
    {'L' , 50},
    { 'C' , 100 },
    {'D',  500 },
    { 'M' , 1000 }
            };

        public static int Parse(string roman)
        {
            

            int result = 0;
            for(int i = 0; i < roman.Length; i++)
            {
                if(i+1 < roman.Length && isSubtractive(roman[i], roman[i+1]))
                {
                    result -= map[roman[i]];
                }
                else
                {
                     result += map[roman[i]];
                }
            }
            return result;
            

        }
        public static bool isSubtractive(char a1, char a2)
        {
            return map[a1] < map[a2];
        }

    }
}
