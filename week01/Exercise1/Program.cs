using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string last_name = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {last_name}, {name} {last_name}");
    }
}