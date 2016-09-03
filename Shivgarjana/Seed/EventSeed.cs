using Shivgarjana.Models.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shivgarjana.Seed
{
    public class EventSeed
    {
        private List<Event> Events { get; set; }


        public EventSeed()
        {
            Events = new List<Event>();
            Events.Add(new Event
            {
                EventID = 1,
                Title = "Telagu Ganesh Procession",
                Description = "Telagu Ganesh Procession",
                DateTime = new DateTime(2016,9,10),
                Location = new Location { LocationID = 1, Suburb = "Parrmatta", State = "NSW" , Country = "Australia"}
            });
            Events.Add(new Event
            {
                EventID = 2,
                Title = "Helensburg Ganesh Procession",
                Description = "Helensburg Ganesh Procession",
                DateTime = new DateTime(2016, 9, 11),
                Location = new Location { LocationID = 2, Suburb = "Helensburg", State = "NSW", Country = "Australia" }
            });
        }

        public List<Event> GetAllEvents()
        {
            return Events;
        }

        public void Add(Event eventInstance)
        {
            Events.Add(eventInstance);
        }


    }
}