using System.Collections.Generic;

namespace BasketballTickets.Models.ViewModels
{
    public class TicketsBookingViewModel
    {
        public Game Game { get; set; }
        public List<Ticket> AvailableTickets { get; set; }
        public List<Ticket> BookedTickets { get; set; }
    }
}
