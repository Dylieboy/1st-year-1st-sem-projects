using System;

namespace AverageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            int count = 0;

            do
            {
                Console.Write("Enter a number (or -1 to stop): ");

                // Safe input validation to prevent crashes from letters/spaces
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number != -1)
                    {
                        sum += number;
                        count++; // Correctly grouped inside the curly braces!
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (number != -1);

            // Safely calculate the average only if the user entered at least one valid number
            if (count > 0)
            {
                // Cast sum to (double) to force decimal division instead of integer truncation
                double average = (double)sum / count;

                Console.WriteLine($"\nThe total sum is: {sum}");
                Console.WriteLine($"The average is:   {average:F2}"); // Rounds neatly to 2 decimal places
            }
            else
            {
                Console.WriteLine("\nNo numbers were entered.");
            }
        }//end main
    }//end class
}//end namespace