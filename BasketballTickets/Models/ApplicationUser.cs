using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BasketballTickets.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ShoppingCart ShoppingCart { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
