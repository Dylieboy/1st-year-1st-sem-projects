using System;

namespace FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");

            // Safe input validation to prevent crashes
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                // I use 'long' to prevent overflow.
                // I start at 1 because multiplying by 0 would ruin the math.
                long factorial = 1;

                // Special case: 0! is mathematically defined as 1
                if (number == 0)
                {
                    Console.WriteLine("0! = 1");
                }
                else
                {
                    // Standard loop starting at 1
                    for (int i = 1; i <= number; i++)
                    {
                        // Calculate the factorial using multiplication
                        factorial *= i;

                        // Beautifully format the step-by-step math output
                        if (i < number)
                        {
                            Console.Write(i + " x ");
                        }
                        else
                        {
                            Console.Write(i + " = ");
                        }
                    }

                    // Print the final result
                    Console.WriteLine(factorial);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer (0 or greater).");
            }
        }//end main
    }//end class
}//end namespace