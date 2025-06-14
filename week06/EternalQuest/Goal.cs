using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public Goal(string[] things)
    {
        _shortName = things[0];
        _description = things[1];
        _points = things[2];
    }

    public string GetName()
    {
        return _shortName;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        return IsComplete();
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
}