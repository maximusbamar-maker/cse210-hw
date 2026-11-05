public class Reflection : QuestionActivity
{
    private List<String> _prompts;

    public Reflection(String name, String description, List<String> questions, List<String> prompts) : base(name, description, questions)
    {
        _prompts = prompts;
    }

    public void AskPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        int rndInt = rnd.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[rndInt]);

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");

        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Clear();
    }

    public void RunActivity()
    {   
        ShowPrologue();
        AskPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        while (currentTime < endTime)
        {   
            AskQuestion(false);
            Spinner(30);

            currentTime = DateTime.Now;
        }

        Console.WriteLine();

        ShowEpilouge();
    }
}