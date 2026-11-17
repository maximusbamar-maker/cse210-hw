public class EternalGoal : Goal
{
    public EternalGoal(String title, String description, int points) : base(title, description, points)
    {}

    public override void Display()
    {
        Console.WriteLine($" [ ] {_title} ({_description})");
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{_title}`{_description}`{_points}";
    }

    public override int ScoreGoal()
    {
        return _points;
    }
}