using System.Drawing;

public class Rectangle : Shape
{
    private Double _length;
    private Double _width;

    public Rectangle(String color, Double length, Double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override Double GetArea()
    {
        return _length * _width;
    }
}