using System.Drawing;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;
    private int _xp = 0;
    private int _level;

    public GoalManager()
    {

    }
    public void Start()
    {
        string answer = "";
        while (answer != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                default:
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {
        int index = 0;
        foreach (Goal goal in _goals)
        {
            index++;
            Console.WriteLine($"{index}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("What is the type of goal would you like to create? ");
        string name;
        string description;
        string points;
        string amount;
        string type = Console.ReadLine();
        switch (type)
        {
            case "1":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Console.ReadLine();
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                amount = Console.ReadLine();
                int target = int.Parse(amount);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                amount = Console.ReadLine();
                int bonus = int.Parse(amount);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                break;
            default: break;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Wich goals did you accomplished? ");
        string goal = Console.ReadLine();
        int index = int.Parse(goal);
        int points = _goals[index - 1].RecordEvent();
        _score += points;
        _xp++;
        if (_xp == 10)
        {
            _xp = 0;
            _level++;
            Console.WriteLine($"Congrats!! Now you are level {_level}");
        }
        Console.WriteLine($"Xp:{_xp}");
        Console.WriteLine($"Congratulations you have earned {points} points");
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename of the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score},{_level},{_xp}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        string[] score = lines[0].Split(",");
        _score = int.Parse(score[0]);
        _level = int.Parse(score[1]);
        _xp = int.Parse(score[2]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] things = parts[1].Split(",");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(things);
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(things);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(things);
                _goals.Add(checklistGoal);
            }
        }
    }
}