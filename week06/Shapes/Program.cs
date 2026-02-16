using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        Circle circle = new Circle("Blue", 3.5);
        Square square = new Square("Purple", 5);
        Rectangle rectangle = new Rectangle("Black", 5, 9);

        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"Area: {area}cm - Color: {color}");
        }
    }
}