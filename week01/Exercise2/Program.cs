using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int numberedGrade = int.Parse(grade);

        string letter = null;

        if (numberedGrade >= 90)
        {
            letter = "A";
        }
        else if (numberedGrade >= 80)
        {
            letter = "B";
        }
        else if (numberedGrade >= 70)
        {
            letter = "C";
        }
        else if (numberedGrade >= 60)
        {
            letter = "D";
        }
        else if (numberedGrade < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        
        if (numberedGrade >= 70)
        {
            Console.WriteLine("Congrats!!");
        }
        else
        {
            Console.WriteLine("That's a lame :(");
        }
    }   
}