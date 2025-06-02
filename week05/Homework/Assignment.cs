

public class Assignment
{

    private string _studentName = "";
    private string _topic = "";

    public Assignment(string sutdentName, string topic)
    {
        _studentName = sutdentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetName()
    {
        return _studentName;
    }

}