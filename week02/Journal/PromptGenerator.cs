using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = [];

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        return _prompts[r];
    }
}