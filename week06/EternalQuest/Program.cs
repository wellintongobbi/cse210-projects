using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {

            Console.WriteLine($"\n\nYou have {manager.GetScore()} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Register Progress");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.WriteLine("\nSelect an option: ");
            string opt = Console.ReadLine();

            if (opt == "1") manager.CreateGoal();
            else if (opt == "2") manager.DisplayGoals();
            else if (opt == "3") manager.RecordEvent();
            else if (opt == "4") manager.DisplayScore();
            else if (opt == "5") manager.Save();
            else if (opt == "6") manager.Load();
            else if (opt == "7") break;
        }
    }
}