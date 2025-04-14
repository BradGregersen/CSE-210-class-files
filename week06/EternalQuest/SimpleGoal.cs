using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        CurrentlyFinished = true;
    }

    public override string GetStatus()
    {
        return CurrentlyFinished ? "[X] " + TaskName : "[ ] " + TaskName;
    }
}
