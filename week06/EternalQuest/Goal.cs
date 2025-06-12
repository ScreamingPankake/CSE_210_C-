

public class Goal
{
    protected string _goal;
    protected string _description;
    protected int _points;

    public Goal(string goal, string description, int points)
    {
        _goal = goal;
        _description = description;
        _points = points;
    }


    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetails()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

    public virtual string GetGoalName()
    {
        return "";
    }

    public virtual string GetGoal()
    {
        return "";
    }
}