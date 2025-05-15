// Change to accept csv files explained in Journal.cs 

using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;

        PromptGenerator promptList = new PromptGenerator();
        promptList._prompts = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        ];

        Journal data = new Journal();

        string filename = "";
        bool loop = true;

        do
        {
            Entry first = new Entry();

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            string randomPrompt = promptList.GetRandomPrompt();
            string date = theCurrentTime.ToShortDateString();

            // Write
            if (number == 1)
            {
                Console.WriteLine(randomPrompt);
                string userInput = Console.ReadLine();

                first._entryText = userInput;
                first._date = date;
                first._promptText = randomPrompt;

                data.AddEntry(first);
            }
            // Display
            else if (number == 2)
            {
                data.DisplayAll();
            }
            // Load
            else if (number == 3)
            {
                Console.Write("Enter the file name: ");
                filename = Console.ReadLine();

                data.LoadFromFile(filename);

            }
            // Save
            else if (number == 4)
            {
                Console.Write("Enter the file name: ");
                filename = Console.ReadLine();

                data.SaveToFile(filename);
            }
            // Quit
            else if (number == 5)
            {
                loop = false;
            }
        } while (loop);
    }
}