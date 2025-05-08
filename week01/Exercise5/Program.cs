using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

    DisplayWelcome();
    string name = GetName();
    int favnum = GetFavNum();
    int numSquare = SquareNum(favnum);

    DisplayResult(name, numSquare);
    }

        
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.WriteLine("What is your name? ");
        string fullName = Console.ReadLine();

        return fullName;
    }


    static int GetFavNum()
    {
        Console.WriteLine("What is your favorite number? ");
        string favnumstr = Console.ReadLine();
        int favnum = int.Parse(favnumstr);

        return favnum;
    }

    static int SquareNum(int favNum)
    {
        int number = favNum * favNum;

        return number;
    }


    static void DisplayResult(string name, int numSquare)
    {
        Console.WriteLine($"{name}, the square of your number is {numSquare}");
    }
}