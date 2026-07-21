using System;

namespace TeamTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array to store a maximum of 10 company email addresses
            string[] companyEmails = new string[10];

            // Ask the user whether they want to start the program
            Console.Write("Do you want to continue? (y/n): ");

            if (Console.ReadLine().Trim().ToLower() != "y")
                return;

            // Variable used to keep the menu running
            bool running = true;

            // Main program loop
            while (running)
            {
                Console.Clear();

                // Display the main menu
                Console.WriteLine("=================================");
                Console.WriteLine(" COMPANY EMAIL ADDRESS MANAGER");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Add New Address");
                Console.WriteLine("2. Delete Address");
                Console.WriteLine("3. View Addresses");
                Console.WriteLine("0. Exit");
                Console.Write("\nChoose an option: ");

                // Validate the user's menu selection
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid option.");
                    Pause();
                    continue;
                }

                // Execute the selected menu option
                switch (choice)
                {
                    case 1:
                        AddAddresses(companyEmails);
                        break;

                    case 2:
                        DeleteAddress(companyEmails);
                        break;

                    case 3:
                        ViewAddresses(companyEmails);
                        break;

                    case 0:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid menu option.");
                        Pause();
                        break;
                }
            }
        }

        // Method used to add new email addresses
        static void AddAddresses(string[] emails)
        {
            // Loop through the array to find an empty position
            for (int i = 0; i < emails.Length; i++)
            {
                // Skip positions that already contain an email
                if (emails[i] != null)
                    continue;

                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine().Trim();

                Console.Write("Enter Surname: ");
                string surname = Console.ReadLine().Trim();

                // Ensure the user entered valid names
                if (string.IsNullOrWhiteSpace(firstName) ||
                    string.IsNullOrWhiteSpace(surname))
                {
                    Console.WriteLine("Names cannot be empty.");
                    i--;
                    continue;
                }

                // Generate the company email address
                emails[i] = $"{firstName.ToLower()}{surname.ToLower()}@jdl.co.za";

                Console.WriteLine($"\nCreated: {emails[i]}");

                // Ask if another employee should be added
                Console.Write("\nAdd another? (y/n): ");

                if (Console.ReadLine().Trim().ToLower() != "y")
                    break;
            }

            Pause();
        }

        // Method used to delete an existing email address
        static void DeleteAddress(string[] emails)
        {
            // Display all stored email addresses
            ViewAddresses(emails);

            Console.Write("\nEnter the number to delete: ");

            if (int.TryParse(Console.ReadLine(), out int index))
            {
                // Check if the selected index is valid
                if (index >= 1 &&
                    index <= emails.Length &&
                    emails[index - 1] != null)
                {
                    emails[index - 1] = null;
                    Console.WriteLine("Address deleted.");
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }

            Pause();
        }

        // Method used to display all stored email addresses
        static void ViewAddresses(string[] emails)
        {
            Console.WriteLine("\nStored Company Email Addresses");
            Console.WriteLine("--------------------------------");

            bool found = false;

            // Loop through the array and display stored addresses
            for (int i = 0; i < emails.Length; i++)
            {
                if (emails[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {emails[i]}");
                    found = true;
                }
            }

            // Display a message if no addresses have been stored
            if (!found)
            {
                Console.WriteLine("No email addresses stored.");
            }

            Pause();
        }

        // Method used to pause the program before returning to the menu
        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}