using System;

namespace StudentMarksManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double itmFinal = 0;
            double sodFinal = 0;
            double psaFinal = 0;
            double iteFinal = 0;
            double lcsFinal = 0;
            double pimFinal = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("     STUDENT MARKS MANAGER");
                Console.WriteLine("================================");
                Console.WriteLine("1. ITM");
                Console.WriteLine("2. SOD");
                Console.WriteLine("3. PSA");
                Console.WriteLine("4. ITE");
                Console.WriteLine("5. LCS");
                Console.WriteLine("6. PIM");
                Console.WriteLine("0. Exit");
                Console.Write("\nChoose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid option.");
                    Pause();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        itmFinal = CalculateITM();
                        Console.WriteLine($"\nFinal ITM Mark: {itmFinal:F2}%");
                        break;

                    case 2:
                        sodFinal = CalculateITM();
                        Console.WriteLine($"\nFinal SOD Mark: {sodFinal:F2}%");
                        break;

                    case 3:
                        psaFinal = CalculatePSA();
                        Console.WriteLine($"\nFinal PSA Mark: {psaFinal:F2}%");
                        break;

                    case 4:
                        iteFinal = ReadSingleMark("ITE");
                        Console.WriteLine($"\nFinal ITE Mark: {iteFinal:F2}%");
                        break;

                    case 5:
                        lcsFinal = CalculateLCS();
                        Console.WriteLine($"\nFinal LCS Mark: {lcsFinal:F2}%");
                        break;

                    case 6:
                        pimFinal = ReadSingleMark("PIM");
                        Console.WriteLine($"\nFinal PIM Mark: {pimFinal:F2}%");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                double overallAverage =
                    (itmFinal + sodFinal + psaFinal + iteFinal + lcsFinal + pimFinal) / 6;

                Console.WriteLine($"\nOverall Average: {overallAverage:F2}%");

                Pause();
            }
        }//end main

        static double CalculateITM()
        {
            int[] marks = ReadMarks(3, "Test");

            double semester =
                (((marks[0] + marks[1]) / 2.0) / 100) * 50;

            double final =
                (marks[2] / 100.0) * 50;

            return semester + final;
        }//end ITM Calculator

        static double CalculatePSA()
        {
            double[] marks = new double[6];

            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = ReadMark($"Task {i + 1}");
            }

            double classTests =
                ((marks[0] + marks[1] + marks[2] + marks[3]) / 4) * 0.20;

            double test1 = marks[4] * 0.30;
            double test2 = marks[5] * 0.50;

            return classTests + test1 + test2;
        }//end PSA Calculator

        static double CalculateLCS()
        {
            int[] marks = ReadMarks(2, "Test");

            return (marks[0] + marks[1]) / 2.0;
        }//end PSA Calculator


        static int[] ReadMarks(int amount, string title)
        {
            int[] marks = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                marks[i] = (int)ReadMark($"{title} {i + 1}");
            }

            return marks;
        }

        static double ReadSingleMark(string subject)
        {
            return ReadMark($"{subject} Mark");
        }

        static double ReadMark(string title)
        {
            while (true)
            {
                Console.Write($"Enter {title}: ");

                if (double.TryParse(Console.ReadLine(), out double mark)
                    && mark >= 0
                    && mark <= 100)
                {
                    return mark;
                }

                Console.WriteLine("Please enter a value between 0 and 100.");
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}