using System;

namespace CoinFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Move Random outside the loop so it's only created ONCE
            Random coin = new Random();
            int count = 0;

            // This loop runs exactly 5 times (0, 1, 2, 3, 4)
            do
            {
                Console.Write("Enter heads or tails (h/t): ");
                string selection = Console.ReadLine();

                Console.WriteLine("The choice is....");

                // 2. Generate a 0 or 1 (standard binary choice)
                int flipResult = coin.Next(0, 2);

                if (flipResult == 0)
                {
                    Console.WriteLine("Heads!");
                }
                else
                {
                    Console.WriteLine("Tails!!");
                }

                Console.WriteLine(); // Adds a blank line for readability between rounds
                count++;

            } while (count < 5);

        }//end main
    }//end class
}//end namespace