using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you did something worthwhile.",
        "Think of a time when you helped someone who needed a hand.",
        "Think of a time when you tried to help someone but it didn't work out.",
        "Think of a time when you did something you regret, what did you learn from this?."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override string RetrieveRepresentation()
    {
        return "This activity will help you reflect upon times in your life where you made pivotal choices and what you learned from those choices.";
    }

    protected override void ExecuteProcess()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        DisplayAnimation(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            string question = Questions[random.Next(Questions.Count)];
            Console.WriteLine(question);
            DisplayAnimation(3);
            elapsed += 3;
        }
    }
}
