public class Activity
{
    protected String _name;
    protected String _description;
    protected int _duration;

    public Activity(String name, String description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void ShowPrologue()
    {
        Console.WriteLine($"Welcome to the {_name}.{Environment.NewLine}");
        Console.WriteLine($"{_description}{Environment.NewLine}");
        Console.Write("How long, in seconds, would you like for your session? ");
        String durInput = Console.ReadLine();
        _duration = int.Parse(durInput);

        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(5);
    }

    public void ShowEpilouge()
    {
        Console.WriteLine("Well done!!");
        Spinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Spinner(5);
    }

    protected void Spinner(int spins)
    {   
        int spinTime = 100;

        for (int i=0; i < spins; i++)
        {
            Console.Write("-");
            Thread.Sleep(spinTime);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(spinTime);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(spinTime);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(spinTime);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void Countdown(int dur)
    {
        for (int i = dur; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
