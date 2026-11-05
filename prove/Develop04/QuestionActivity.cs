using System.Reflection.Emit;

public class QuestionActivity : Activity
{
    private List<String> _questions;
    private List<Boolean> _questionAsked = new List<Boolean>();
    protected Random rnd = new Random();

    public QuestionActivity(String name, String description, List<String> questions) : base(name, description)
    {
        _questions = questions;

        for (int i=0; i<_questions.Count; i++)
        {
            _questionAsked.Add(false);
        }
    }

    public void CheckQuestionsAsked()
    {
        Boolean allTrue = true;
        foreach (Boolean b in _questionAsked)
        {
            if (!b)
            {
                allTrue = false;
            }
        }

        if (allTrue)
        {
            for (int i=0; i<_questions.Count; i++)
            {
                _questionAsked[i] = false;
            }
        }
    }
    
    public void AskQuestion(Boolean lineBreak)
    {   
        CheckQuestionsAsked();

        int rndInt = 0;

        Boolean findingNum = true;
        while (findingNum)
        {
            rndInt = rnd.Next(0, _questions.Count);

            if (!_questionAsked[rndInt])
            {
                _questionAsked[rndInt] = true;
                findingNum = false;
            }
        }

        Console.Write(_questions[rndInt]);

        if (lineBreak)
        {
            Console.WriteLine();
        }
    }
}