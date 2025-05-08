using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Please enter your first name: ");
        string firstname = Console.ReadLine();

        Console.WriteLine($"Please enter your last name: ");
        string lastname = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}