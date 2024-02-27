namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime TimesStamp { get; protected set; }

        public Event()
        {
            TimesStamp= DateTime.Now;
        }
    }
}
