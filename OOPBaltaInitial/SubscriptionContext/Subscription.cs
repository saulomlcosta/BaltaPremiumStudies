using OOPBaltaInitial.SharedContext;

namespace OOPBaltaInitial.SubscriptionContext;

public abstract class Subscription : Base
{
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsInactive => EndDate <= DateTime.Now;
}
