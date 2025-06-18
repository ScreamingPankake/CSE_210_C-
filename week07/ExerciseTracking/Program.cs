using System;
using System.ComponentModel;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        Running running = new Running(3, 30);
        Console.WriteLine(running.GetSummary());

        Bicycles bicycles = new Bicycles(3, 30);
        Console.WriteLine(bicycles.GetSummary());

        Swimming swimming = new Swimming(3, 30);
        Console.WriteLine(swimming.GetSummary());
    }
}