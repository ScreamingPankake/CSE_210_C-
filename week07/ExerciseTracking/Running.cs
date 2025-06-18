using System;

public class Running : Activity
{

    private float _distance;
    private float _speed;
    private float _pace;
    private int _minutes;
    private DateTime date = DateTime.Now;
    
    public Running(float distance, int minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        _speed = (_distance / _minutes) * 60;
        return _speed;
    }

    public override float GetPace()
    {
        _pace = _minutes / _distance;
        return _pace;
    }

    public override string GetSummary()
    {

        return $"{date} Running ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}