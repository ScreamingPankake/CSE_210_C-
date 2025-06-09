using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 3, 7);
        Circle circle = new Circle("Yellow", 4);

        List<Shape> shapes = new List<Shape>() { square, rectangle, circle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}