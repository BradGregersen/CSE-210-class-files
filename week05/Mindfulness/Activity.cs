using System;
using System.Threading;

abstract class Activity
{
    protected int duration;

    public void Start()
    {
        ShowInitialMessage();
        ExecuteProcess();
        ShowEndingMessage();
    }

    protected void ShowInitialMessage()
    {
        Console.Clear();
        Console.WriteLine($"Beginning {GetType().Name}...");
        Console.WriteLine(RetrieveRepresentation());
        Console.Write("How long would you like to do this activity(in seconds)?: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Clear your mind of distractions and find a quiet place.");
        DisplayAnimation(3);
    }

    protected void ShowEndingMessage()
    {
        Console.WriteLine("You're a natural!");
        DisplayAnimation(3);
        Console.WriteLine($"You have practiced the {GetType().Name} for {duration} seconds.");
        DisplayAnimation(3);
    }

    protected void DisplayAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    protected abstract string RetrieveRepresentation();
    protected abstract void ExecuteProcess();
}
