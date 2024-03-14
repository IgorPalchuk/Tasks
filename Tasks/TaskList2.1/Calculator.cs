using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskList2._1
{
    public class Calculator
    {
        private static string Calc;
         static Calculator() 
        {
            Calc = "This is calculator";
            Console.WriteLine(Calc);
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;   
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new ArgumentException("Fail to divide by 0");
            }
            else
            {
                return a / b;
            }
            
        }
    }
}
