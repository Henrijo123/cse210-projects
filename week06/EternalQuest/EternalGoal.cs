using System.Runtime.CompilerServices;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public EternalGoal(string[] things) : base(things)
    {
    }

    public override int RecordEvent()
    {
        int points = int.Parse(_points);
        return points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}