using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", Math.Pow(Math.PI, Math.PI));
        Rectangle rectangle = new Rectangle("green", 2.47, 3.2);
        Circle circle = new Circle("blue", Math.PI);

        List<Shape> shapes = new List<Shape>()
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine();
        }
    }
}