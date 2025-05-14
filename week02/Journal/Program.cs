using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        String[] questions = {
            "What was one thing you did today that you were proud of? ",
            "What are 3 beautiful things you saw today? ",
            "What is one thing you enjoyed doing today? ",
            "What was your favorite thing that happened today?",
            "What was something you accomplished today? ",
            "What is an interesting thought you had today? "
        };
        List<string> answers = new List<string>();

        Random random = new Random();

        int choice = 0;

        while (choice != 5)
        {
            int randIndex = random.Next(questions.Length);
            System.Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            string choiceStr = Console.ReadLine();
            choice = Int16.Parse(choiceStr);

            if (choice == 1)
            {
                System.Console.WriteLine(questions[randIndex]);
                answers.Add(Console.ReadLine());
            }

            if (choice == 2)
            {
                foreach (string answer in answers)
                {
                    System.Console.WriteLine(answer);
                }
            }

            if (choice == 3)
            {
                System.Console.WriteLine("What is the name of the file you would like to load? ");
                string filename = Console.ReadLine();
                filename = filename + ".txt";
                answers = FileEdit.LoadFile(filename);
            }

            if (choice == 4)
            {
                System.Console.WriteLine("Write the name of the file you want to save to, or type a new name if you want a new file.");
                string filename = Console.ReadLine();
                filename = filename + ".txt";

                FileEdit.FileSave(filename, answers);
            }

        }
    }
}