public class Assignment
{
    private String _studentName;
    private String _topic;

    public Assignment(String name, String topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public String GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}