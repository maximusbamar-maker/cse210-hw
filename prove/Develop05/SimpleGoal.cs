public class SimpleGoal : Goal
{
    private Boolean _completed = false;

    public SimpleGoal(String title, String description, int points) : base(title, description, points)
    {}

    public SimpleGoal(String title, String description, int points, Boolean completed) : base(title, description, points)
    {
        _completed = completed;
    }

    public override void Display()
    {
        char mark = ' ';

        if (_completed)
        {
            mark = 'X';
        }
        
        Console.WriteLine($" [{mark}] {_title} ({_description})");
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{_title}`{_description}`{_points}`{_completed}";
    }

    public override int ScoreGoal()
    {
        _completed = true;
        return _points;
    }
}