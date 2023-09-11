using System.Collections.Generic;

namespace BasketballTickets.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string LogoPath { get; set; }

        public int LeagueId { get; set; }
        public League League { get; set; }

        public int ArenaId { get; set; }
        public Arena Arena { get; set; }

        public ICollection<Game> HomeGames { get; set; }
        public ICollection<Game> AwayGames { get; set; }
    }
}
