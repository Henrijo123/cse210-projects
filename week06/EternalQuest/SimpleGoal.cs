public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }
    public SimpleGoal(string[] things) : base(things)
    {
        _isComplete = things[3] == "True";
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            int points = int.Parse(_points);
            _isComplete = true;
            return points;
        }
        return 0;

    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}