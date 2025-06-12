

public class EternalGoal : Goal
{
    public EternalGoal(string goal, string description, int points, string placeHolder) : base(goal, description, points)
    {
        _goal = goal;
        _description = description;
        _points = points;
        string _placeHolder = placeHolder;
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goal} ({_description})";
    }

    public override string GetGoalName()
    {
        return _goal;
    }

    public override string GetGoal()
    {
        return $"{_goal},{_description},{_points}";
    }
}