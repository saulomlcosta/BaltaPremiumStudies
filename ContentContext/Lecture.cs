using OOPBaltaInitial.ContentContext.Enums;
using OOPBaltaInitial.SharedContext;

namespace OOPBaltaInitial.ContentContext;

public class Lecture : Base
{
    public int Order { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}