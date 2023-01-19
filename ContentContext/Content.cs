using OOPBaltaInitial.SharedContext;

namespace OOPBaltaInitial.ContentContext;

public abstract class Content : Base
{
    public Content(string title, string url)
    {
        Id = Guid.NewGuid();
        Title = title;
        Url = url;
    }

    public Guid Id { get; private set; }
    public string Title { get; set; }
    public string Url { get; set; }
}