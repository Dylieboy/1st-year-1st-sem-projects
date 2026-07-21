using System;

namespace EmployeeDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int EmployeeCount = 3;
            const int DataFields = 3;

            string[] headers = { "Name", "Title", "Salary" };
            string[,] employees = new string[EmployeeCount, DataFields];

            Console.WriteLine("=================================");
            Console.WriteLine("      EMPLOYEE INFORMATION");
            Console.WriteLine("=================================\n");

            // Read employee information
            for (int row = 0; row < EmployeeCount; row++)
            {
                Console.WriteLine($"Employee {row + 1}");

                for (int column = 0; column < DataFields; column++)
                {
                    Console.Write($"Enter {headers[column]}: ");
                    employees[row, column] = Console.ReadLine();
                }

                Console.WriteLine();
            }

            // Display table
            Console.WriteLine("\n==============================================");

            foreach (string header in headers)
            {
                Console.Write($"{header,-20}");
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 60));

            for (int row = 0; row < EmployeeCount; row++)
            {
                for (int column = 0; column < DataFields; column++)
                {
                    Console.Write($"{employees[row, column],-20}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}