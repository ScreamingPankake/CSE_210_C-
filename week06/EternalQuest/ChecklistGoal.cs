

public class ChecklistGoal : Goal
{

    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private bool isComplete;

    public ChecklistGoal(string goal, string description, int points, int target, int bonus) : base(goal, description, points)
    {
        _goal = goal;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }


    public override bool IsComplete()
    {
        isComplete = _amountCompleted >= _target;
        return isComplete;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                isComplete = true;
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goal} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetGoalName()
    {
        return _goal;
    }

    public override string GetGoal()
    {
        return $"{_goal},{_description},{_points},{_target},{_bonus}";
    }
}