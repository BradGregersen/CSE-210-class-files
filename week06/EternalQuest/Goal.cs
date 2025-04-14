using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    public string _name;
    public int _points;
    public bool _isCompleted;

    public string TaskName
    {
        get { return _name; }
        protected set { _name = value; }
    }

    public int TotalPoints
    {
        get { return _points; }
        protected set { _points = value; }
    }

    public bool CurrentlyFinished
    {
        get { return _isCompleted; }
        set { _isCompleted = value; }
    }

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();

    public static Goal GenerateFreshGoal()
    {
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.Write("Choose a goal type: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                return new SimpleGoal(name, points);
            case "2":
                return new EternalGoal(name, points);
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                return new ChecklistGoal(name, points, targetCount, bonusPoints);
            default:
                throw new InvalidOperationException("Invalid goal type");
        }
    }

    public static void RevealGoals(List<Goal> goals)
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    public static void RetainList(List<Goal> goals, int score)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal.TaskName}|{goal.TotalPoints}|{goal.CurrentlyFinished}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.CurrentCount}|{checklistGoal.TargetCount}|{checklistGoal.BonusPoints}");
                }
            }
        }
    }

    public static List<Goal> LoadGoals(out int score)
    {
        List<Goal> goals = new List<Goal>();
        score = 0;

        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isCompleted = bool.Parse(parts[3]);

                    Goal goal = null;
                    if (type == nameof(SimpleGoal))
                    {
                        goal = new SimpleGoal(name, points);
                    }
                    else if (type == nameof(EternalGoal))
                    {
                        goal = new EternalGoal(name, points);
                    }
                    else if (type == nameof(ChecklistGoal))
                    {
                        int currentCount = int.Parse(reader.ReadLine());
                        int targetCount = int.Parse(reader.ReadLine());
                        int bonusPoints = int.Parse(reader.ReadLine());
                        goal = new ChecklistGoal(name, points, targetCount, bonusPoints)
                        {
                            CurrentCount = currentCount
                        };
                    }

                    if (goal != null)
                    {
                        goal.CurrentlyFinished = isCompleted;
                        goals.Add(goal);
                    }
                }
            }
        }

        return goals;
    }
}
