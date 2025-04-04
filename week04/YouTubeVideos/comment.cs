public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
        return $"[{Name}]: {Text}";
    }
}