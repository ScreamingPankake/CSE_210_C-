using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        int sum = 0;
        int largest = 0;
        int newNum = -1;
        int count = 0;
    
        while (newNum != 0)
        {
            Console.WriteLine("Enter Number: ");
            String numString = Console.ReadLine();
            newNum = int.Parse(numString);
            if (newNum != 0)

            numList.Add(newNum);

        }


        for (int i = 0; i < numList.Count; i++)
        {
            sum += numList[i];

            if (numList[i] > largest)
            {
                largest = numList[i];
            }

            count++;
        }

        float average = sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}