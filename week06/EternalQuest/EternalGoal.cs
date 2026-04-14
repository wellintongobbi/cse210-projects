public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) {}

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}