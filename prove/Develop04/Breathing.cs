public class Breathing : Activity
{
    public Breathing(String name, String description) : base(name, description)
    {}

    public void RunActivity()
    {
        ShowPrologue();

        int time = 0;

        while (time < _duration)
        {
            Console.Write("Breath in...");
            Countdown(4);
            Console.Write("Breat out...");
            Countdown(4);
            Console.WriteLine();
            time += 8;
        }

        ShowEpilouge();
    }
    
}