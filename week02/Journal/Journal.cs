// Journal.cs
using System;
using System.Collections.Generic;
using System.Text.Json;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string selectedPrompt = prompts[index];
        Console.WriteLine(selectedPrompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry entry = new Entry(date, selectedPrompt, response);
        Entries.Add(entry);
    }

    public void ViewEntries()
    {
        Console.WriteLine("Current entries:");
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }


    public void SaveEntries()
    {
        string jsonString= JsonSerializer.Serialize(Entries);
        File.WriteAllText("entries.json",jsonString);
    }

    public void LoadEntries()
    {
        if(File.Exists("entries.json"))
        {
            string jsonString = File.ReadAllText("entries.json");
            Entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }
        else
        {
            Console.WriteLine("No saved entries found");
        }

    }
}
