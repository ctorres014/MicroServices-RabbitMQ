using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimesStamp { get; protected set; }

        protected Command() { 
            TimesStamp = DateTime.Now;
        }
    }
}
