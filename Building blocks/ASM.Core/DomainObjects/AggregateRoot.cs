using ASM.Core.Messages;
using System.ComponentModel;

namespace ASM.Core.DomainObjects
{
    public abstract class AggregateRoot
    {
        private readonly List<IEvent> Events;
        
        public AggregateRoot()
        {
            Events = new List<IEvent>();      
        }

        public void AddEvent(IEvent @event)
        {
            Events.Add(@event);
        }
        
        public List<IEvent> GetEvents()
        {
            return Events;
        }


    }
}
