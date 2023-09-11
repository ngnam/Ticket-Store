using System.Collections.Generic;

namespace BasketballTickets.Models
{
    public class GameType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
