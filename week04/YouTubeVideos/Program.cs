using System;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Print_Videos(1);
        Print_Videos(2);
        Print_Videos(3);
    }

    static void Print_Videos(int select_num)
    {
        System.Console.WriteLine($"Video: {Video.Get_Video_Title(select_num)} ");
        System.Console.WriteLine($"This video had {Video.num_Of_Comments(select_num)} comments.");
        foreach (string[] comment in Comments.Get_Comments(select_num))
        {
            System.Console.WriteLine($"User: {comment[0]} | Comment: {comment[1]}");
        }
        System.Console.WriteLine();
    }
}