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
                Location = new Location { LocationID = 1, Suburb = "Parrmatta", State = "NSW" , Country = "Australia"},
                Media = new List<Gallery> {
                                            new Gallery {
                                                GalleryID = 1,
                                                Title = "Telugu Association Inc Sydney",
                                                Description = "Telagu mandal",
                                                MultimediaType = MultimediaType.Photo,
                                                Url = "http://www.trueindia.com.au/GetImage.ashx?id=330&value=event&h=0&w=0"
                                                //Url = "./Content/Images/Telagu_Mandal_Ganesha.jpg"
                                            } }
            });

            Events.Add(new Event
            {
                EventID = 2,
                Title = "Helensburg Ganesh Procession",
                Description = "Helensburg Ganesh Procession",
                DateTime = new DateTime(2016, 9, 11),
                Location = new Location { LocationID = 2, Suburb = "Helensburg", State = "NSW", Country = "Australia" },
                Media = new List<Gallery> {
                                            new Gallery {
                                                GalleryID = 2,
                                                Title = "Helensburg mandal",
                                                Description = "Helensburg mandal",
                                                MultimediaType = MultimediaType.Photo,
                                                Url = "./Content/Images/Helensburg_Ganesha.jpg" } }
            });

            Events.Add(new Event
            {
                EventID = 3,
                Title = "Helensburg Ganesh Procession",
                Description = "Helensburg Ganesh Procession",
                DateTime = new DateTime(2015, 9, 11),
                Location = new Location { LocationID = 2, Suburb = "Helensburg", State = "NSW", Country = "Australia" },
                Media = new List<Gallery> {
                                            new Gallery {
                                                GalleryID = 1,
                                                Title = "Helensburg mandal",
                                                Description = "Helensburg mandal",
                                                MultimediaType = MultimediaType.Photo,
                                                Url = "./Content/Images/Helensburg_Ganesha.jpg" },
                                             new Gallery {
                                                GalleryID = 2,
                                                Title = "Helensburg mandal",
                                                Description = "Helensburg mandal",
                                                MultimediaType = MultimediaType.Video,
                                                Url = "https://www.youtube.com/embed/AxeSG7LQP5A" }}
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