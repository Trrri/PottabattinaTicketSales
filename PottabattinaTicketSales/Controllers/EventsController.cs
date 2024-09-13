using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using PottabattinaTicketSales.Models;

namespace PottabattinaTicketSales.Controllers
{
    public class EventsController : Controller
    {
        /*
         * Created by Triveni Pottabattina
         * 7777777777777777777777777777777
         */

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult EventList(string id = "All")
        {
            //uses EventService to get the events,either all by default if there is no incoming value, or based on the ID of the event.
            //Instantiate the EventService class:

            EventsService eventsService = new EventsService();

            //List of categories:
            List<Category> categories = new List<Category>();

            //List of Events:
            List<Event> events = new List<Event>();

            //get the events based on Categoty ID:
            if (id == "All") 
            {
                //get all events:
                events = eventsService.GetAllEvents();
            }
            else 
            {
                //Based on ID fund the category behind asked for, if ID is specified then use the category to return all events of that type
                //variable to hold category id:
                int selectedCategoryId = 0;
                foreach (Category cat in categories) 
                {
                    if (cat.CategoryName == id) 
                    {
                        selectedCategoryId = cat.Id;
                    }//if
                }//foreach
                foreach (Event anEvent  in eventsService.GetAllEvents()) 
                {
                    if (anEvent.CategoryID == selectedCategoryId) 
                    {
                        events.Add(anEvent);
                    }//id


                }//loop for finding events.
            }//if else
            //return ListViewModel as a ViewModel with a collection of events 
            ListViewModel listViewModel = new ListViewModel(events, categories, id);

            return View(listViewModel);
        }//EventList()

        [ResponseCache(NoStore =true, Duration = 0)]
        public IActionResult Details(int id) 
        {
            EventsService eventsService = new EventsService();
            Event oneEvent = eventsService.GetEvent(id);
            return View(oneEvent);
        }//Details()

    }//Controller
}//Namespace
