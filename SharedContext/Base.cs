using OOPBaltaInitial.NotificationContext;

namespace OOPBaltaInitial.SharedContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}