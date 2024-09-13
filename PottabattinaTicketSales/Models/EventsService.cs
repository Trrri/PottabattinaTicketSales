namespace PottabattinaTicketSales.Models
{

    public class EventsService
    {
        /*
         * Created by Triveni Pottabattina
         * 33333333333333333333333333333333
         * This is a class that creates list of events with each event of type Event class
         * Creates a list of categories with each category of type Category class.
         * Has three methods:
         * GetEvents() which returns events based on incoming parameter category
         * Get Categories() that returns the list of categories ot events.
         * GetAllEvents() will return all categories.
         */
        private List<Event> _allEvents = new List<Event>() 
        {
            new Event() {Id = 100, Title = "The Lion King", CategoryID = 1, TicketPrice = 50, Description = "Musical Based on Disney's animated movie.", ImageId="100.png"},
            new Event(){Id = 200, Title = "Holiday Spectacular", CategoryID = 2, TicketPrice = 40, Description = "Holiday extravaganza for the entire family.", ImageId="200.png"},
            new Event(){Id = 300, Title = "Mary Poppins", CategoryID = 1, TicketPrice =  50, Description = "The popular musical with seven Tony awards.", ImageId="300.png"},
            new Event(){Id = 400, Title = "Taylor Swift", CategoryID = 2, TicketPrice = 90, Description = "Popular singer and songwriter.", ImageId="400.png"},
            new Event(){Id = 500, Title = "Alice in Wonderland", CategoryID = 1, TicketPrice = 90, Description = "Alice's Adventures in Wonderland and Through the Looking-Glass by Lewis Carroll", ImageId="500.png"}
        };

        private List<Category> _allCategories = new() 
        {
        new Category() {Id = 1, CategoryName = "Theater show" }, new Category(){Id = 2,CategoryName = "Concert"}
        };

        public Event GetEvent(int id)
        {
            //incoming parameter id comes from the <a> link in the details view where ID is either all, or a specific category name.
            Event? selectedEvent = null;

            foreach (Event anEvent in _allEvents)
            {
                if (anEvent.Id == id)
                {
                    selectedEvent = anEvent;
                }//if
            }//foreach
            return selectedEvent;
        }//GetEvent()
        public List<Category> GetCategories() { return _allCategories; }

        public List<Event> GetAllEvents() { return _allEvents; }
    
    }//EventService

}//namespace PottabattinaTicketSales.Models
