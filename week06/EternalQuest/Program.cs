// Added xp and levels, for every Event recorded xp will increase in 1 and for every 10 xp the level will increase in 1.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}