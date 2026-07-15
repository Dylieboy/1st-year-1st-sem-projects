using System;

namespace RestaurantRating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your rating (1 - Good or 2 - Bad): ");

            // int.TryParse checks if the input is a valid number before trying to convert it
            if (int.TryParse(Console.ReadLine(), out int rating))
            {
                switch (rating)
                {
                    case 1:
                        Console.WriteLine("The food is good");
                        break;

                    case 2:
                        Console.WriteLine("The food is bad");
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            else
            {
                // Handles cases where the user inputs text, symbols, or nothing at all
                Console.WriteLine("Invalid Input. Please enter a valid number.");
            }
        }//end main
    }//end class
}//end namespace