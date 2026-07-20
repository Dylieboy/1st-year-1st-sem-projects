using System;

namespace PracticeUnit5Exam10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many student scores are you going to read in: ");

            if (!int.TryParse(Console.ReadLine(), out int numberOfStudents) || numberOfStudents <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }

            int[] scores = new int[numberOfStudents];
            int total = 0;

            // Read student scores
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter student {i + 1} score: ");

                while (!int.TryParse(Console.ReadLine(), out scores[i]) || scores[i] < 0)
                {
                    Console.Write("Invalid input. Enter a valid positive score: ");
                }

                total += scores[i];
            }

            Console.WriteLine("\nHistogram");
            Console.WriteLine("---------");

            // Display histogram
            foreach (int score in scores)
            {
                Console.WriteLine($"{new string('*', score)} {score}");
            }

            double average = (double)total / numberOfStudents;

            Console.WriteLine("\n-------------------------");
            Console.WriteLine($"Average score: {average:F2}");
        }//end main
    }//end class
}//end namespace