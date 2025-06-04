using System;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {

        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            string choicestr = Console.ReadLine();
            choice = Int32.Parse(choicestr);

            if (choice == 1)
            {
                Console.Clear();
                Breathing breathing_activity = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing");
                Console.WriteLine(breathing_activity.GetPrompt());
                Console.Write("(10 Second Min)");
                string timerStr = Console.ReadLine();
                int timer = Int32.Parse(timerStr);

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(timer);

                while (DateTime.Now < endTime)
                {
                    Breathing.GetBreating();
                }
                System.Console.WriteLine("Well Done!!");
                System.Console.WriteLine();
                Console.WriteLine(breathing_activity.GetEnding(timer));
                Activity.GetLoadingAnim(3);
            }
            else if (choice == 2)
            {
                Console.Clear();
                Reflection reflection_activity = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine(reflection_activity.GetPrompt());
                Console.Write("");
                string timerStr = Console.ReadLine();
                int timer = Int32.Parse(timerStr);

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(timer);

                string prompt = reflection_activity.GetQuestion();
                string reflect = reflection_activity.GetReflection();

                Activity.GetReady(2);
                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine($" --- {prompt} --- ");
                Console.WriteLine("When you have something in mind, press enter to continue.");
                Console.ReadLine();
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.WriteLine("You may begin in: ");
                Activity.GetTimer(5);
                Console.Clear();

                while (DateTime.Now <= endTime)
                {
                    Console.WriteLine(reflection_activity.GetReflection());
                    Activity.GetLoadingAnim(2);
                    System.Console.WriteLine();
                }

                Console.WriteLine("Well Done!!");
                Console.WriteLine();
                Console.WriteLine(reflection_activity.GetEnding(timer));
                Activity.GetLoadingAnim(3);
            }
            else if (choice == 3)
            {
                Console.Clear();
                Listing listingActivity = new Listing("Reflection Activity", "This activity will help you reflect on the good things in your life by having you list as many\nthings as you can in a certain area.");
                Console.WriteLine(listingActivity.GetPrompt());
                Console.Write("");
                string timerStr = Console.ReadLine();
                int timer = Int32.Parse(timerStr);

                Console.Clear();
                Activity.GetReady(2);
                Console.WriteLine("List as many responses as you can to the following prompt:");
                Console.WriteLine($" --- {listingActivity.GetListPrompt()} ---");
                Console.WriteLine("You may begin in: ");
                Console.Write("");
                Activity.GetTimer(5);

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(timer);

                while (DateTime.Now <= endTime)
                {
                    Console.Write(">");
                    string answer = Console.ReadLine();
                    listingActivity.AddListItem(answer);
                }
                System.Console.WriteLine($"You have listed {listingActivity.GetListLen()} items!");
                System.Console.WriteLine();
                System.Console.WriteLine("Well done!!");
                System.Console.WriteLine();
                System.Console.WriteLine(listingActivity.GetEnding(timer));
                Activity.GetLoadingAnim(3);

            }
        }

        Console.WriteLine("Goodbye.");
    }
}