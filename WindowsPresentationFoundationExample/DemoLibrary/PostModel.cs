namespace DemoLibrary;

public class PostModel
{
    public string Subject { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return $"{Subject}: {Content}";
    }
}