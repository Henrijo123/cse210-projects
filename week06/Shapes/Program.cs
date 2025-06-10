using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> list = [
        ];

        Square square = new Square("yellow", 5);
        Rectangle rectangle = new Rectangle("blue", 5, 8);
        Circle circle = new Circle("yellow", 5);

        list.Add(square);
        list.Add(rectangle);
        list.Add(circle);

        foreach (Shape shape in list)
        {
            Console.WriteLine($"Color : {shape.GetColor()}, Area: {shape.GetArea()}\n");
        }
    }
}