

public class Activity
{
    protected string _title;
    protected string _discription;

    public Activity(string title, string discription)
    {
        _title = title;
        _discription = discription;
    }

    public string GetPrompt()
    {
        return $"Welcome to the {_title}!\n\n{_discription}\n\nHow long, in seconds, would you like for your session? ";
    }

    public string GetEnding(int timer)
    {
        return $"You have completed another {timer} seconds of the {_title}";
    }

    public static void GetReady(int timer)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        GetLoadingAnim(timer);
        System.Console.WriteLine();
        System.Console.WriteLine();
    }


    public static void GetLoadingAnim(int timer)
    {
        for (int i = 0; i <= timer; i++)
        {
            Console.Write("|");
            Thread.Sleep(125);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(125);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(125);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(125);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(125);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(125);
            Console.Write("\b \b");
        }
    }

    public static void GetTimer(int timer)
    {
        for (int i = timer; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}