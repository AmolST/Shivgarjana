using Shivgarjana.Models.Event;
using Shivgarjana.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shivgarjana.Controllers
{
    public class EventController : Controller
    {
        private EventService eventService = new EventService(); 
        // GET: Event
        public ActionResult Index()
        {
            List<Event> eventsModel = eventService.GetAllEvents();
            return View(eventsModel);
        }
    }
}