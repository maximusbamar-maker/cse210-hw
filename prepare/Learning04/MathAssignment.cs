public class MathAssignment : Assignment
{
    private String _textbookSection;
    private String _problems;

    public MathAssignment(String name, String topic, String section, String problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public String GetHomeworkList()
    {
        String header = GetSummary();
        String questions = $"Section {_textbookSection} Problems {_problems}";
        return $"{header}{Environment.NewLine}{questions}";
    }
}