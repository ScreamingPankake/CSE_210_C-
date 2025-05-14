using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction f1 = new Fraction();
        System.Console.WriteLine(f1.GetFractionString());
        System.Console.WriteLine(f1.getDecimalValue());
        Fraction f2 = new Fraction(5);
        System.Console.WriteLine(f2.GetFractionString());
        System.Console.WriteLine(f2.getDecimalValue());
        Fraction f3 = new Fraction(3,4);
        System.Console.WriteLine(f3.GetFractionString());
        System.Console.WriteLine(f3.getDecimalValue());
        Fraction f4 = new Fraction(1,3);
        System.Console.WriteLine(f4.GetFractionString());
        System.Console.WriteLine(f4.getDecimalValue());
    }
}