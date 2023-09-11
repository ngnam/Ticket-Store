using System.Collections.Generic;

namespace BasketballTickets.Models
{
    public class Arena
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
