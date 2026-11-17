public abstract class Goal
{
    protected String _title;
    protected String _description;
    protected int _points;

    public Goal (String title, String description, int points) {
        _title = title;
        _description = description;
        _points = points;
    }

    public abstract void Display();
    public abstract String GetSaveString();
    public abstract int ScoreGoal();
}