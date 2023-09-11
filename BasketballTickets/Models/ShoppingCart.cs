using System.Collections.Generic;

namespace BasketballTickets.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
