using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
