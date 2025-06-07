public class JumpingActivity : Activity
{
    public JumpingActivity() : base("Jumping Activity", "This activity will help you clear your mind by jumping!!. Clear your mind and just Jump.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Start Jumping...");
        ShowJump(GetDuration());
        Console.WriteLine("Stop!!");

        DisplayEndingMessage();
    }
}