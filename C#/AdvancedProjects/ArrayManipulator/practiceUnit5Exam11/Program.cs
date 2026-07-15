using System;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 10, 5, 7, 2, 4, 9, 3, 6 };

            // 1. Dynamic Access: Always works, no matter how much the array size changes!
            Console.WriteLine("First Value: " + numberArray[0]);

            // Using "Length - 1" dynamically finds the last index of any array
            Console.WriteLine("Last Value:  " + numberArray[numberArray.Length - 1]);
            Console.WriteLine();

            // 2. Display all original values using foreach
            Console.WriteLine("Original Array:");
            foreach (int number in numberArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n"); // Double newline for clean spacing

            // 3. Increment each value by 10 and display the updated array
            Console.WriteLine("Updated Array (Each value + 10):");
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] += 10;
                Console.Write(numberArray[i] + " ");
            }
            Console.WriteLine(); // Final clean line break
        }
    }
}