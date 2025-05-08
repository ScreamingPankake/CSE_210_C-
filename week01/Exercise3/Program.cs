using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        Console.WriteLine(number);

        while (guess != number)
        {
            Console.WriteLine("What is your guess?");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess > number)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher.");
            }
            else if (guess == number)
            {
                Console.WriteLine("YOU WIN!!");
            }
        }

    }
}