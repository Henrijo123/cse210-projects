using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow", 5);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("blue", 5, 8);

        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("yellow", 5);

        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}