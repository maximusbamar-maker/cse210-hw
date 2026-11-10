public class Square : Shape
{
    private Double _side;

    public Square(String color, Double side) : base(color)
    {
        _side = side;
    }

    public override Double GetArea()
    {
        return _side * _side;
    }
}