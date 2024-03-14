using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskList2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "121";
            Console.WriteLine(str.Extension()); 
        }
         
       
    }
    public static class StringExtension
    {
        public static bool Extension(this string s)
        {
            char[] chars = s.ToCharArray();
            chars.Reverse();
            string result = new string(chars);

            return s == result;
;
        }
    }
}
