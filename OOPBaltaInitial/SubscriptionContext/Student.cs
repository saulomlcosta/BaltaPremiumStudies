using OOPBaltaInitial.NotificationContext;
using OOPBaltaInitial.SharedContext;

namespace OOPBaltaInitial.SubscriptionContext;

public class Student : Base
{
    public Student()
    {
        Subscriptions = new List<Subscription>();
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new Notification("Premium", "The student already has a subscription"));
            return;
        }

        Subscriptions.Add(subscription);
    }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
}