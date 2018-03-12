using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder2.Models
{
    public class Deck
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public int Amount { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public List<CardDeck> CardDecks { get; set; }
        public List<Comment> Comments { get; set; }

        public Deck()
        {
            Amount = 0;
        }
    }
}
