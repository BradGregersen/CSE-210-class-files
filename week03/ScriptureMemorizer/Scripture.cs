using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;
    private string _reference;


    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetDisplayText();
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }



    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var wordsToHide = _words.Where(w => !w.IsHidden()).OrderBy(x => random.Next()).Take(numberToHide).ToList();
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }


    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }


    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
    public override string ToString()
    {
        return $"{_reference}: {GetDisplayText()}";
    }
}
