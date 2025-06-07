// Added a new Jump activity with a new jumping animation

using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        JumpingActivity jumpingActivity = new JumpingActivity();

        string entry = "";
        while (entry != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Start jumping activity");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choicee from the menu: ");
            entry = Console.ReadLine();
            switch (entry)
            {
                case "1":
                    breathingActivity.Run();
                    break;
                case "2":
                    reflectingActivity.Run();
                    break;
                case "3":
                    listingActivity.Run();
                    break;
                case "4":
                    jumpingActivity.Run();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("enter a valid number");
                    break;
            }
        }
    }
}