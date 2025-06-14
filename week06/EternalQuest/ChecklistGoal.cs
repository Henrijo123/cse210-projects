public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string[] things) : base(things)
    {
        _target = int.Parse(things[4]);
        _bonus = int.Parse(things[3]);
        _amountCompleted = int.Parse(things[5]);
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int points = int.Parse(_points);
        if (_amountCompleted == _target)
        {
            return _bonus + points;
        }
        else if (_amountCompleted < _target)
        {
            return points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        return true;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}