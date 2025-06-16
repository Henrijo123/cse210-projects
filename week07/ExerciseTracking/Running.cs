public class Running : Activity
{
    private float _distance;

    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetPace()
    {
        return _length / _distance;
    }
    public override float GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}