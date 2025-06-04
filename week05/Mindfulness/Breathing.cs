using System;

public class Breathing : Activity
{
    public Breathing(string title, string discription) : base(title, discription)
    {
        _title = title;
        _discription = discription;
    }

    public static void GetBreating()
    {
        Console.Write("Breath in...");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write("\b \b");
        Console.WriteLine();
        Console.Write("Breath out...");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write("\b \b");
        Console.WriteLine();
        Console.WriteLine();
    }
}