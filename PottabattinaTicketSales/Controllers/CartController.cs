using Microsoft.AspNetCore.Mvc;
using PottabattinaTicketSales.Models;

namespace PottabattinaTicketSales.Controllers
{
    public class CartController : Controller
    {
        /*
         * Created by Triveni Pottabattina
         * 8888888888888888888888888888888
         */
        public IActionResult Buy(int id)
        {
            //gets the ID of the event that the user wants to you ticket for and then,
            //usi9nt the EventsService, gets an object representing the event.

            EventsService eventsService = new EventsService();
            Event selectedEvent = eventsService.GetEvent(id);

            //Start buying ticket by creating buyTicket object and setting name of the event and ticket price. (constructor of Buy class).
            BuyTickets buyTickets = new BuyTickets(selectedEvent.Title,selectedEvent.TicketPrice);
           
            return View(buyTickets);
        }
        public IActionResult Confirmation(BuyTickets model) { 

            if (ModelState.IsValid) 
            {
                //call the buyTickets object's method to calculate sale price
                model.CalculateAmountDue();
                //pass buytickets objects as viewmodel to dispaly ticket Information

                return View(model);
            }
            return View("Buy", model); //take the user back to buy tickets page.
        }
    }
}
