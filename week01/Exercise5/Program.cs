using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your Name: ");
            string name =Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter a Number: ");
            string entry =Console.ReadLine();
            int number = int.Parse(entry);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.Write($"{name}, the square of your number is {squaredNumber}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int squaredNumber = SquareNumber(PromptUserNumber());
        DisplayResult(name, squaredNumber);
    }
}