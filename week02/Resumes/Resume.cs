using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = [];

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job item in _jobs)
        {
            item.Display();
        }
    }
}