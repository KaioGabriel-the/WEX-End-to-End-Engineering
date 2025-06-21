using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // Not a Number
            }
            return Math.Round(a / b, 2);
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Error: Cannot compute square root of a negative number.");
                return double.NaN; // Not a Number
            }
            return Math.Round(Math.Sqrt(a), 2); // Round to 2 decimal places
        }

        public double Power(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        public double Sine(double angle)
        {
            double radians = angle * Math.PI / 180; // Convert degrees to radians
            return Math.Round(Math.Sin(radians), 2);
        }

        public double Cosine(double angle)
        {
            double radians = angle * Math.PI / 180; // Convert degrees to radians
            return Math.Round(Math.Cos(radians), 2);
        }

        public double Tangent(double angle)
        {
            double radians = angle * Math.PI / 180; // Convert degrees to radians
            return Math.Round(Math.Tan(radians), 2); // Round to 2 decimal places
        }
    }
}