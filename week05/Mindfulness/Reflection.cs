

public class Reflection : Activity
{


    public Reflection(string title, string discription) : base(title, discription)
    {
        _title = title;
        _discription = discription;
    }

    public string GetQuestion()
    {
        Random random = new Random();
        List<string> prompts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};

        int indexPrompt = random.Next(prompts.Count);
        return prompts[indexPrompt];
    }

    public string GetReflection()
    {
        Random random = new Random();
        List<string> reflections = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        int indexReflect = random.Next(reflections.Count);
        return reflections[indexReflect];
    }
}