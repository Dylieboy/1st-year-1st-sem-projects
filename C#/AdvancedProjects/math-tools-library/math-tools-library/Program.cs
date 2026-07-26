using System;
using myMathTools;

namespace MathToolsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate every method in the MathTools library.
            Console.WriteLine("===== MATH TOOLS DEMO =====\n");

            Console.WriteLine($"Add: 10 + 5 = {MathTools.Add(10, 5)}");
            Console.WriteLine($"Subtract: 10 - 5 = {MathTools.Subtract(10, 5)}");
            Console.WriteLine($"Multiply: 10 × 5 = {MathTools.Multiply(10, 5)}");
            Console.WriteLine($"Divide: 10 ÷ 5 = {MathTools.Divide(10, 5)}");

            Console.WriteLine($"\nHypotenuse (3,4): {MathTools.CalculateHypotenuse(3, 4)}");

            Console.WriteLine($"Binary of 25: {MathTools.ToBinary(25)}");

            Console.WriteLine($"100°F = {MathTools.ToCelsius(100)}°C");
            Console.WriteLine($"0°C = {MathTools.ToFahrenheit(0)}°F");

            Console.WriteLine($"2^8 = {MathTools.Power(2, 8)}");
            Console.WriteLine($"√144 = {MathTools.SquareRoot(144)}");

            Console.WriteLine($"Average of 80, 90, 100 = {MathTools.Average(80, 90, 100):F2}");

            Console.WriteLine($"Factorial of 5 = {MathTools.Factorial(5)}");

            Console.WriteLine($"20 is even? {MathTools.IsEven(20)}");
            Console.WriteLine($"15 is odd? {MathTools.IsOdd(15)}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
