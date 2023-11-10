using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5, "white");
        Rectangle rectangle = new Rectangle(5, 3, "black");
        Circle circle = new Circle(2.2, "maroon");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}