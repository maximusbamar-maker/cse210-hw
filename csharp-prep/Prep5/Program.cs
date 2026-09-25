using System;

class Program
{
    static void Main(string[] args)
    {   
        string userName;
        int userNum;
        int userBirthYear;
        int numSqr;

        DisplayWelcome();
        userName = PromptUserName();
        userNum = PromptUserNumber();
        userBirthYear = PromptUserBirthYear();
        numSqr = SquareNumber(userNum);
        DisplayResult(userName, numSqr, userBirthYear);
    }

    static void DisplayWelcome()
    {   
        // Displays the message, "Welcome to the Program!
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {   
        // Asks for and returns the user's name (as a string)
        string userName;

        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {   
        // Asks for and returns the user's favorite number (as an integer)
        int userNum;
        string userInput;

        Console.Write("Please enter your favorite number: ");
        userInput = Console.ReadLine();
        userNum = int.Parse(userInput);

        return userNum;
    }

    static int PromptUserBirthYear()
    {   
        // Accepts out integer parameter and prompts the user for the year they were born. 
        // The out parameter is set to their birth year. This function does not return a value. 
        // The user's birth year is given back from the function via the out parameter.
        int userBirthYear;
        string userInput;

        Console.Write("Please enter the year you were born: ");
        userInput = Console.ReadLine();
        userBirthYear = int.Parse(userInput);

        return userBirthYear;
    }

    static int SquareNumber(int num)
    {   
        // Accepts an integer as a parameter and returns that number squared (as an integer)
        return num * num;
    }

    static void DisplayResult (string userName, int numSqr, int birthYear)
    {
        // Accepts the user's name, the squared number, and the user's birth year. 
        // Display the user's name and squared number. 
        // Calculate hold many years old they will turn this year and display that.
        int year = DateTime.Now.Year;
        int age = year - birthYear;

        Console.WriteLine($"{userName}, the square of your number is {numSqr}");
        Console.WriteLine($"{userName}, you will turn {age} this year.");
    }
}