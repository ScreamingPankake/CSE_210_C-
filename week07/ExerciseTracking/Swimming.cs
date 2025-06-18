

public class Swimming : Activity
{

    private float _distance;
    private float _speed;
    private float _pace;
    private int _laps;
    private int _minutes;

    private DateTime date = DateTime.Now;

    public Swimming(int minutes, int laps)
    {
        _minutes = minutes;
        _laps = laps;
    }

    public override float GetDistance()
    {
        _distance = _laps * 50 / 1000;
        return _distance;
    }

    public override float GetSpeed()
    {
        _speed = (GetDistance() / _minutes) * 60;
        return _speed;
    }

    public override float GetPace()
    {
        _pace = _minutes / GetDistance();
        return _pace;
    }

    public override string GetSummary()
    {
        return $"{date} Swimming ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}