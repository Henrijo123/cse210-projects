using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine("Welcome to Guess my number");
        bool guessed = false;
        int tries = 0;
        do
        {
            Console.Write("Enter your guess: ");
            string entry = Console.ReadLine();
            int guess = int.Parse(entry);
            if (guess  > number)
            {
                Console.WriteLine("Lower");
                tries++;
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                tries++;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                tries++;
                Console.WriteLine($"It took you {tries} tries");
                guessed = true;
            }
        } while (guessed == false);
    }
}