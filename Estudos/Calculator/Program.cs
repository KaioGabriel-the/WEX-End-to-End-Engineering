using System;
using Calculator.entities;

namespace MyCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.entities.Calculator calculator = new Calculator.entities.Calculator();

            Console.WriteLine("Welcome to the Calculator App!");
            Console.WriteLine("Enter two numbers:");

            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Subtraction: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Division: {calculator.Divide(num1, num2)}");

            Console.WriteLine("Enter a number for square root:");
            double sqrtNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Square Root: {calculator.SquareRoot(sqrtNum)}");

            Console.WriteLine("Enter base and exponent for power calculation:");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            double exponent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Power: {calculator.Power(baseNum, exponent)}");

            Console.WriteLine("Enter an angle in degrees for trigonometric functions:");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sine: {calculator.Sine(angle)}");
            Console.WriteLine($"Cosine: {calculator.Cosine(angle)}");
            Console.WriteLine($"Tangent: {calculator.Tangent(angle)}");
        }
    }
}