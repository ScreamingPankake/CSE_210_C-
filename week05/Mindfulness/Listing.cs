

using System.Formats.Asn1;

public class Listing : Activity
{

    private List<string> _answers = new List<string>() { };
    public Listing(string title, string discription) : base(title, discription)
    {
        _title = title;
        _discription = discription;
    }

    public string GetListPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random random = new Random();

        int promptIndex = random.Next(prompts.Count);

        return prompts[promptIndex];
    }

    public void AddListItem(string newItem)
    {
        _answers.Add(newItem);
    }

    public int GetListLen()
    {
        int i = 0;
        foreach (string answer in _answers)
        {
            i++;
        }
        return i;
    }
}