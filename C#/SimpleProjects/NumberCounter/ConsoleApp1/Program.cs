using System;

namespace NumberCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Counters should be integers (int) since they only count whole steps
            int positive = 0;
            int negative = 0;
            int zero = 0;

            // Loop runs exactly 10 times (from 1 to 10)
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i} of 10: ");

                // Parsing as double so users can enter decimal numbers safely
                double number = double.Parse(Console.ReadLine());

                if (number == 0)
                {
                    zero++;
                }
                else if (number > 0)
                {
                    positive++;
                }
                else // If it's not 0 and not positive, it must be negative
                {
                    negative++;
                }
            }

            // Clean formatted output
            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Positive numbers: \t{positive}");
            Console.WriteLine($"Negative numbers: \t{negative}");
            Console.WriteLine($"Zeroes:           \t{zero}");
        }
    }
}