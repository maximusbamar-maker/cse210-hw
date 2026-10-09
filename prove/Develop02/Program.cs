using System;
class Program
{
    static void Main(string[] args)
    {   
        Journal userJournal = new Journal();
        userJournal._entries = new List<Entry>();

        // auto load entries
        userJournal.Load();

        string choice;

        while (true)
        {
            Console.WriteLine("Please select one of following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Clear");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Write
                userJournal.AddEntry();
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                // Display
                Console.WriteLine();
                userJournal.DisplayEntries();
            }
            else if (choice == "3")
            {
                // Load
                userJournal.Load();
                Console.WriteLine("Entries Loaded");
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                // Save
                userJournal.Save();
                Console.WriteLine("Entries Saved");
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
                userJournal.Save();
                Console.WriteLine("Entries Saved");
                break;
            }
            else if (choice == "6")
            {
                Console.WriteLine("Are you sure you want to clear all journal entries?");
                Console.Write("Y/n ");
                choice = Console.ReadLine();
                if (choice == "Y")
                {
                    userJournal.Clear();
                    Console.WriteLine("Entries Cleared");
                    Console.WriteLine();
                }
            }
            else
            {
                // Invalid response
                Console.WriteLine("Invalid response, please enter a number 1-5.");
                Console.WriteLine();
            }
        }
    }
}