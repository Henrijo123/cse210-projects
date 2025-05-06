using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");

        int sum = 0;
        string entry = Console.ReadLine();
        int number = int.Parse(entry);
        int largest = 0;

        List<int> numbers = new List<int>(); 
        while (number != 0)
        {   
            if (largest < number)
            {
                largest = number;
            }
            numbers.Add(number);
            sum += number;
            Console.Write("Enter number: ");
            entry = Console.ReadLine();
            number = int.Parse(entry);
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}