using System.Collections.Generic;

namespace BasketballTickets.Models.ViewModels
{
    public class CategorizedGamesViewModel
    {
        public string GamesType { get; set; }
        public ICollection<GameViewModel> Games { get; set; }
    }
}
