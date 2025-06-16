public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }
    public virtual float GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}