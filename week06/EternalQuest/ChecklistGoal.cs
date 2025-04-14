using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    public int _currentCount;
    private int _bonusPoints;

    public int TargetCount
    {
        get { return _targetCount; }
        private set { _targetCount = value; }
    }

    public int CurrentCount
    {
        get { return _currentCount; }
        set { _currentCount = value; }
    }

    public int BonusPoints
    {
        get { return _bonusPoints; }
        private set { _bonusPoints = value; }
    }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            CurrentlyFinished = true;
        }
    }

    public override string GetStatus()
    {
        return CurrentlyFinished ? $"[X] {TaskName} (Completed {CurrentCount}/{TargetCount} times)" : $"[ ] {TaskName} (Completed {CurrentCount}/{TargetCount} times)";
    }
}
