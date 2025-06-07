public class ReflectingActivity : Activity
{
    private List<string> _prompts = [];
    private List<string> _questions = [];

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = ["Think of a time when you stood up for someone else. ",
                    "Think of a time when you did something really difficult. ",
                    "Think of a time when you helped someone in need. ",
                    "Think of a time when you did something truly selfless. "];

        _questions = ["Why was this experience meaningful to you? ",
                    "Have you ever done anything like this before? ",
                    "How did you get started? ",
                    "How did you feel when it was complete? ",
                    "What made this time different than other times when you were not as successful? ",
                    "What is your favorite thing about this experience? ",
                    "What could you learn from this experience that applies to other situations? ",
                    "What did you learn about yourself through this experience? ",
                    "How can you keep this experience in mind in the future? "];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\n When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (startTime < endTime)
        {
            DisplayQuestions();
            Console.Write("\n");
            startTime = DateTime.Now;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.Write($">{GetRandomQuestion()}");
        ShowSpinner(5);
    }
}