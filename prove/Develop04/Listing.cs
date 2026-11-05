public class Listing : QuestionActivity
{
    public Listing(String name, String description, List<String> questions) : base(name, description, questions)
    {}

    public void GetResponse()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        AskQuestion(true);

        while (currentTime < endTime)
        {   
            Console.Write("> ");
            Console.ReadLine();

            currentTime = DateTime.Now;
        }

        Console.WriteLine();
    }

    public void RunActivity()
    {
        ShowPrologue();
        GetResponse();
        ShowEpilouge();
    }
}