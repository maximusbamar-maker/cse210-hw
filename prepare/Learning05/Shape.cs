public abstract class Shape
{
    protected String _color;

    public Shape(String color)
    {
        _color = color;
    }

    public String GetColor()
    {
        return _color;
    }

    public void SetColor(String color)
    {
        _color = color;
    }

    public abstract Double GetArea();
}