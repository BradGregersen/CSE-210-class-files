// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Entry");
            Console.WriteLine("2. View entries");
            Console.WriteLine("3. Save entries");
            Console.WriteLine("4. Load entries");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.ViewEntries();
                    break;
                case "3":
                    journal.SaveEntries();
                    break;
                case "4":
                    journal.LoadEntries();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
