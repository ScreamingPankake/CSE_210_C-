

public class WritingAssignment : Assignment
{

    private string _title;
    public WritingAssignment(string sutdentName, string topic, string title) : base(sutdentName, topic)
    {
        _title = title;
    }

    public string GetWrititngInformation()
    {
        return $"{_title} by {GetName()}";
    }
}