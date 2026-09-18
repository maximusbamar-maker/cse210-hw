using System;

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            char secondChar = userInput[1];
            int secondDigit = (int)Char.GetNumericValue(secondChar);
            
            if (secondDigit >= 7 && letter != "A")
            {
                letter += "+";
            }
            else if (secondDigit <= 3)
            {
                letter += "-";
            }
        }

        Console.WriteLine($"You have a {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Good job!");
        }
        else
        {
            Console.WriteLine("You got this");
        }
    }
}