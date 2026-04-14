using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayScore()
    {
        Console.WriteLine($"\n Score: {_score}");
        DisplayLevel();
    }

    private void DisplayLevel()
    {
        if (_score >= 5000) Console.WriteLine("Gold");
        else if (_score >= 1000) Console.WriteLine("Silver");
        else Console.WriteLine("Bronze");
    }

    public void DisplayGoals()
    {   
        Console.WriteLine("\nYour Goals:");
        int i = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Wich type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the description of your goal? ");
        string desc = Console.ReadLine();

        Console.Write("How many points is it worth? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times do you want to complete this goal? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("what is the bonus for completing this goal? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Choose the number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"+{points} points!");
    }

    public void Save()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (var g in _goals)
                sw.WriteLine(g.GetStringRepresentation());
        }
    }

    public void Load()
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] data = parts[1].Split(",");

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));

            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));

            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[4]),
                    int.Parse(data[5])
                ));
        }
    }
    public int GetScore()
{
    return _score;
}
}