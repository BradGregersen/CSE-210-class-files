using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {

    }

    public override string GetStatus()
    {
        return "[ ] " + TaskName;
    }
}
