

public class SimpleGoal : Goal
{
    private bool _complete = false;

    public SimpleGoal(string goal, string description, int points) : base(goal, description, points)
    {
        _goal = goal;
        _description = description;
        _points = points;
    }

    public override int RecordEvent()
    {
        _complete = true;

        return _points;
    }

    public override bool IsComplete()
    {
        return _complete;
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