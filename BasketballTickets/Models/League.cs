using System.Collections.Generic;

namespace BasketballTickets.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }

        public ICollection<Team> Team { get; set; }
    }
}
