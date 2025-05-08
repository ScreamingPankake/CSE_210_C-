using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";

        Console.WriteLine("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        float grade = float.Parse(gradeString);

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("You Pass!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You fail.");
        }
    }
}