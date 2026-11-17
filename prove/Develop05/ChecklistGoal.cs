public class ChecklistGoal : Goal
{
    int _completionGoal;
    int _timesCompleted = 0;
    int _compleationPoints;

    public ChecklistGoal(String title, String description, int points, int completionGoal, int compleationPoints) : base(title, description, points)
    {
        _completionGoal = completionGoal;
        _compleationPoints = compleationPoints;
    }

    public ChecklistGoal(String title, String description, int points, int completionGoal, int compleationPoints, int timesCompleted) : base(title, description, points)
    {
        _completionGoal = completionGoal;
        _compleationPoints = compleationPoints;
        _timesCompleted = timesCompleted;
    }

    public override void Display()
    {   
        char mark = ' ';

        if (_timesCompleted >= _completionGoal)
        {
            mark = 'X';
        }

        Console.WriteLine($" [{mark}] {_title} ({_description}) -- Currently completed: {_timesCompleted}/{_completionGoal}");
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_title}`{_description}`{_points}`{_completionGoal}`{_timesCompleted}`{_compleationPoints}";
    }

    public override int ScoreGoal()
    {
        int pointsScored = _points;

        _timesCompleted += 1;

        if (_timesCompleted == _completionGoal)
        {
            pointsScored += _compleationPoints;
        }

        return pointsScored;
    }
}