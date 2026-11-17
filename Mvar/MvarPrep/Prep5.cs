public class Prep5
{
    public void Run()
    {
        Mvar userName;
        Mvar userNum;
        Mvar userBirthYear;
        Mvar numSqr;

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

    static Mvar PromptUserName()
    {   
        // Asks for and returns the user's name (as a string)
        Mvar userName = new Mvar();

        Console.Write("Please enter your name: ");
        userName.Set(Console.ReadLine());

        return userName;
    }

    static Mvar PromptUserNumber()
    {   
        // Asks for and returns the user's favorite number (as an integer)
        Mvar userNum = new Mvar();

        Console.Write("Please enter your favorite number: ");
        userNum.Set(Console.ReadLine());

        return userNum;
    }

    static Mvar PromptUserBirthYear()
    {   
        // Accepts out integer parameter and prompts the user for the year they were born. 
        // The out parameter is set to their birth year. This function does not return a value. 
        // The user's birth year is given back from the function via the out parameter.
        Mvar userBirthYear = new Mvar();

        Console.Write("Please enter the year you were born: ");
        userBirthYear.Set(Console.ReadLine());

        return userBirthYear;
    }

    static Mvar SquareNumber(Mvar num)
    {   
        // Accepts an integer as a parameter and returns that number squared (as an integer)
        Mvar sqr = new Mvar(num.Val() * num.Val());
        return sqr;
    }

    static void DisplayResult (Mvar userName, Mvar numSqr, Mvar birthYear)
    {
        // Accepts the user's name, the squared number, and the user's birth year. 
        // Display the user's name and squared number. 
        // Calculate hold many years old they will turn this year and display that.
        Mvar year = new Mvar(DateTime.Now.Year);
        Mvar age = new Mvar(year.Val() - birthYear.Val());

        Console.WriteLine($"{userName.Val()}, the square of your number is {numSqr.Val()}");
        Console.WriteLine($"{userName.Val()}, you will turn {age.Val()} this year.");
    }
}