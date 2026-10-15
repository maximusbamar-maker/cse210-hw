using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine("Fraction 1");
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        Console.WriteLine();

        Fraction frac2 = new Fraction(5);
        Console.WriteLine("Fraction 2");
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());
        Console.WriteLine();

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine("Fraction 3");
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
        Console.WriteLine();

        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine("Fraction 4");
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
    }
}