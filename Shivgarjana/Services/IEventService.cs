using Shivgarjana.Models.Event;
using Shivgarjana.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivgarjana.Services
{
    public interface IEventService
    {
        List<Event> GetAllEvents();
        void AddEvent(Event eventInstance);
    }

    public class EventService : IEventService
    {
        private EventSeed eventSeed = new EventSeed();
        
        public List<Event> GetAllEvents()
        {
            return eventSeed.GetAllEvents().OrderByDescending(e => e.DateTime).ToList();
        }

        public void AddEvent(Event eventInstance)
        {
            eventSeed.Add(eventInstance);
        }
    }
}
