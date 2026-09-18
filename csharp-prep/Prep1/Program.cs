using System;

// What is your first name? Brigham
// What is your last name? Young

// Your name is Young, Brigham Young.

class Program
{
    static void Main(string[] args)
    {   
        string firstName;
        string lastName;

        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"The name's {lastName}, {firstName} {lastName}.");
    }
}