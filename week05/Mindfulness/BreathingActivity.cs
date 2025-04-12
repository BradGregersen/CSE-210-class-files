using System;

class BreathingActivity : Activity
{
    protected override string RetrieveRepresentation()
    {
        return "This activity will help you to center yourself and find the peace which already exists within you. Find a comfortable place to relax and clear your mind.";
    }

    protected override void ExecuteProcess()
    {
        int halfDuration = duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Take a deep breath in");
            ShowCountdown(3);
            Console.WriteLine("Take a deep breath out");
            ShowCountdown(3);
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

