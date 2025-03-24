

public class Word
{

    private string _text;
    private bool _cannotBeSeen;

    public Word(string text)
    {
        _text = text;
        _cannotBeSeen = false;

    }


    public void Hide()
    {
        _cannotBeSeen= true;
    }

    public void Show()
    {
        _cannotBeSeen = false;
    }

    public bool IsHidden()
    {
        return _cannotBeSeen;
    }

    public string GetDisplayText()
    {
        return _cannotBeSeen ? new string('-', _text.Length) : _text;
    }
}
