using System;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.Clear();
            GoalManager.DisplayMenu();
            string choiceStr = Console.ReadLine();
            choice = Int32.Parse(choiceStr);

            if (choice == 1)
            {
                GoalManager.CreateGoal();
            }
            else if (choice == 2)
            {
                GoalManager.DisplayGoalDetails();
            }
            else if (choice == 3)
            {
                GoalManager.SaveGoal();
            }
            else if (choice == 4)
            {
                GoalManager.LoadGoals();
            }
            else if (choice == 5)
            {
                GoalManager.RecordEvent();
            }
        }

    }
}

class GoalManager
{
    private static List<Goal> goals = new List<Goal>();
    public static int _score;

    public static void DisplayMenu()
    {
        System.Console.WriteLine(_score);
        System.Console.WriteLine();
        System.Console.WriteLine("Menu Options:");
        System.Console.WriteLine("  1. Create New Goal");
        System.Console.WriteLine("  2. List Goals");
        System.Console.WriteLine("  3. Save Goals");
        System.Console.WriteLine("  4. Load Goals");
        System.Console.WriteLine("  5. Record Event");
        System.Console.WriteLine("  6. Quit");
        System.Console.WriteLine();
        System.Console.Write("Select a choice from the menu: ");
    }

    public static void DisplayGoalNames()
    {
        int i = 1;
        foreach (Goal goal in goals)
        {
            System.Console.WriteLine($"{i}. {goal.GetGoalName()}");
            i++;
        }
    }

    public static void DisplayGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in goals)
        {
            char check = goal.IsComplete() ? 'X' : ' ';
            System.Console.WriteLine($"{i}. [{check}] {goal.GetStringRepresentation()}");
            i++;
        }

        System.Console.WriteLine("Press enter when you want to go back");
        Console.ReadLine();
    }

    public static void CreateGoal()
    {
        System.Console.WriteLine("The types of Goals are:");
        System.Console.WriteLine("  1. Simple Goal");
        System.Console.WriteLine("  2. Eternal Goal");
        System.Console.WriteLine("  3. Checklist Goal");
        System.Console.WriteLine("Which type of goal would you like to create? ");
        System.Console.Write("");
        string goalChoice = Console.ReadLine();
        System.Console.WriteLine("What is the name of your goal? ");
        System.Console.Write("");
        string goalName = Console.ReadLine();
        System.Console.WriteLine("What is a short description of it? ");
        System.Console.Write("");
        string goalDescription = Console.ReadLine();
        System.Console.WriteLine("What is the ammount of points associated with this goal? ");
        System.Console.Write("");
        string pointsStr = Console.ReadLine();
        int points = Int32.Parse(pointsStr);

        Goal goal = new Goal("", "", 0);

        if (goalChoice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
            goal = simpleGoal;
        }
        else if (goalChoice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, points, "");
            goal = eternalGoal;
        }
        else if (goalChoice == "3")
        {
            System.Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            System.Console.Write("");
            string timeAmmountStr = Console.ReadLine();
            int timeAmmount = Int32.Parse(timeAmmountStr);
            System.Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            System.Console.Write("");
            string bonusAmmountStr = Console.ReadLine();
            int bonusAmmount = Int32.Parse(bonusAmmountStr);

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, timeAmmount, bonusAmmount);
            goal = checklistGoal;
        }

        goals.Add(goal);

    }

    public static void SaveGoal()
    {
        System.Console.WriteLine("What is the name of the file? ");
        System.Console.Write("");
        string filename = Console.ReadLine() + ".txt";
        using (StreamWriter outputFile = new StreamWriter(@$"../../../{filename}"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetGoal());
            }
        }
    }

    public static void LoadGoals()
    {
        System.Console.WriteLine("What file would you like to open? ");
        System.Console.Write("");
        string filename = Console.ReadLine() + ".txt";

        string[] lines = System.IO.File.ReadAllLines(@$"../../../{filename}");

        goals.Clear();
        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] values = line.Split(',');
            int len = values.Length;

            if (len == 3)
            {
                string name = values[0];
                string disc = values[1];
                int point = Int32.Parse(values[2]);
                SimpleGoal simpleGoal = new SimpleGoal(name, disc, point);
                goals.Add(simpleGoal);
            }
            else if (len == 4)
            {
                string name = values[0];
                string disc = values[1];
                int point = Int32.Parse(values[2]);
                EternalGoal eternalGoal = new EternalGoal(name, disc, point, "");
                goals.Add(eternalGoal);
            }
            else if (len == 5)
            {
                string name = values[0];
                string disc = values[1];
                int point = Int32.Parse(values[2]);
                int target = Int32.Parse(values[3]);
                int bonus = Int32.Parse(values[4]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, disc, point, target, bonus);
                goals.Add(checklistGoal);
            }
        }
    }

    public static void RecordEvent()
    {
        DisplayGoalNames();
        System.Console.WriteLine("Which goal did you accomplish? ");
        System.Console.Write("");
        string goalChoiceStr = Console.ReadLine();
        int goalChoice = Int32.Parse(goalChoiceStr) - 1;

        if (goalChoice >= 0 && goalChoice < goals.Count)
        {
            int pointsEarned = goals[goalChoice].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total score: {_score}");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}