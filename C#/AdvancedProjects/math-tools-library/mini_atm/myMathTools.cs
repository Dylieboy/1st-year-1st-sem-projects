using System;

namespace myMathTools
{
    /// <summary>
    /// Reusable mathematics helper library.
    /// </summary>
    public static class MathTools
    {
        // Adds two numbers.
        public static double Add(double x, double y) => x + y;

        // Subtracts two numbers.
        public static double Subtract(double x, double y) => x - y;

        // Multiplies two numbers.
        public static double Multiply(double x, double y) => x * y;

        // Divides two numbers.
        public static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return x / y;
        }

        // Calculates the hypotenuse using Pythagoras' theorem.
        public static double CalculateHypotenuse(double sideA, double sideB)
            => Math.Round(Math.Sqrt(sideA * sideA + sideB * sideB), 2);

        // Converts a decimal number to binary.
        public static string ToBinary(long decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string binary = "";

            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }

            return binary;
        }

        // Converts Fahrenheit to Celsius.
        public static double ToCelsius(double fahrenheit)
            => Math.Round((fahrenheit - 32) * 5 / 9, 2);

        // Converts Celsius to Fahrenheit.
        public static double ToFahrenheit(double celsius)
            => Math.Round((celsius * 9 / 5) + 32, 2);

        public static double Power(double number, double exponent)
            => Math.Pow(number, exponent);

        public static double SquareRoot(double number)
            => Math.Sqrt(number);

        public static bool IsEven(int number)
            => number % 2 == 0;

        public static bool IsOdd(int number)
            => number % 2 != 0;

        public static double Average(params double[] numbers)
        {
            double total = 0;
            foreach (double n in numbers)
                total += n;

            return numbers.Length == 0 ? 0 : total / numbers.Length;
        }

        public static long Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be positive.");

            long result = 1;

            for (int i = 2; i <= number; i++)
                result *= i;

            return result;
        }
    }
}
