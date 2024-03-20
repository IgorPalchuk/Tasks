using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public override string ToString()
        {
            return $"Complex = {Real} + {Imaginary}";
        }
        public Complex(double real, double imaginary) 
        { 
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public Complex Plus(Complex complex)
        {
            double newReal = complex.Real;
            double newImaginary = complex.Imaginary;
            double finalReal = newReal + Real;
            double finalImaginary = newImaginary + Imaginary;
            Complex result = new Complex(finalReal, finalImaginary);
            return result;
        }
        public Complex Minus(Complex complex)
        {
            double newReal = complex.Real;
            double newImaginary = complex.Imaginary;
            double finalReal = newReal - Real;
            double finalImaginary = newImaginary - Imaginary;
           Complex result = new Complex(finalReal, finalImaginary);
            return result;
        }
    }
}
