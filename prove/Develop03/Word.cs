class Word
{
    private String _word;
    private Boolean _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Display()
    {
        Console.Write(" ");
        if (_isHidden)
        {
            foreach (char c in _word)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(_word);
        }
    }

    public Boolean GetisHidden()
    {
        return _isHidden;
    }
}