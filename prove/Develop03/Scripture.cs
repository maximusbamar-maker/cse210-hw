class Scripture
{
    private Reference _reference;
    private List<Word> _passage;

    private Random _rand = new Random();

    public Scripture(Reference reference, List<Word> passage)
    {
        _reference = reference;
        _passage = passage;
    }

    public void Display()
    {   
        Console.Clear();
        _reference.Display();
        foreach (Word word in _passage)
        {
            word.Display();
        }
        Console.WriteLine();
    }

    public void DisplayReference()
    {
        _reference.Display();
        Console.WriteLine();
    }

    public Boolean HideWords(int num)
    {
        int length = _passage.Count();

        Boolean allHidden = false;

        for (int i=0; i<num; i++)
        {
            int randomNum = _rand.Next(0, length);

            Boolean isHidden = _passage[randomNum].GetisHidden();

            if (isHidden & !allHidden)
            {
                i--;
                allHidden = true;
                foreach(Word word in _passage)
                {
                    if (!word.GetisHidden())
                    {
                        allHidden = false;
                    }
                }
            }
            else
            {
                _passage[randomNum].Hide();
            }
        }

        return allHidden;
    }
}