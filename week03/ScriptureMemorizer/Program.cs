//I inserted a loop to ensure the user types "quit" or presses ENTER.

using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all your heart and lean not on your own understanding";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n"+scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress ENTER to continue or type 'quit':");
            string input = Console.ReadLine();

            while (input != "" && input.ToLower() != "quit")
            {
                Console.WriteLine("Invalid input. Press ENTER to continue or type 'quit':");
                input = Console.ReadLine();
            }
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nFinished.");
    }
}