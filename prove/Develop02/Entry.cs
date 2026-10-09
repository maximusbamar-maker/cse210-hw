class Entry
{
    public DateTime _date;
    public String _prompt;
    public String _response;

    public void Display()
    {   
        // displays the contents of the object
        Console.WriteLine(_date.ToString("dddd, dd MMMM yyyy"));
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }
}