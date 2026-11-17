public class Job
{
    public Mvar _company = new Mvar();
    public Mvar _jobTitle = new Mvar();
    public Mvar _startYear = new Mvar();
    public Mvar _endYear = new Mvar();

    public void Display()
    {
        Console.WriteLine($"{_jobTitle.Val()} ({_company.Val()}) {_startYear.Val()}-{_endYear.Val()}");
    }
}