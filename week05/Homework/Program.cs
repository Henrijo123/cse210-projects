using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment number1 = new Assignment("MyName", "Geometry");
        Console.WriteLine(number1.GetSummary());

        MathAssignment number2 = new MathAssignment("MyName", "Math", "7.3", "9-19");
        Console.WriteLine($"{number2.GetSummary()}\n{number2.GetHomeworkList()}");

        WritingAssingment number3 = new WritingAssingment("MyName", "European History", "Spain History");
        Console.WriteLine($"{number3.GetSummary()}\n{number3.GetWritingInformation()}");
    }
}