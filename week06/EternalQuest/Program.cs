using System;
using System.Collections.Generic;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    static void Main(string[] args)
    {
        goals = Goal.LoadGoals(out score);
        while (true)
        {
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save and exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goals.Add(Goal.GenerateFreshGoal());
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    Goal.RevealGoals(goals);
                    break;
                case "4":
                    Console.WriteLine($"Current score: {score}");
                    break;
                case "5":
                    Goal.RetainList(goals, score);
                    return;
            }
        }
    }

    static void RecordEvent()
    {
        Goal.RevealGoals(goals);
        Console.Write("Enter goal number to record event: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            goals[goalNumber].RecordEvent();
            score += goals[goalNumber].TotalPoints;

            if (goals[goalNumber] is ChecklistGoal checklistGoal && checklistGoal.CurrentlyFinished)
            {
                score += checklistGoal.BonusPoints;
            }
        }
    }
}
