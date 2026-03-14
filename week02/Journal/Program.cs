using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a option:");
        Console.WriteLine("1. Add Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Save Entries");
        Console.WriteLine("4. Load Entries");
        Console.WriteLine("5. Quit");
        string option = Console.ReadLine();
        Journal journal = new Journal();
        while (option != "5")
        {
            if (option == "1")
            {
                journal.AddEntry();
            }
            else if (option == "2")
            {
                journal.DisplayAll();
            }
            else if (option == "3")
            {
                journal.SaveToFile();
            }
            else if (option == "4")
            {
                journal.LoadFromFile();
            }
            Console.WriteLine("Choose a option:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Entries");
            Console.WriteLine("5. Quit");
            option = Console.ReadLine();
        }
    }
}