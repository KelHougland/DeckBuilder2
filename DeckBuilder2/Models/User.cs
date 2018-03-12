using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder2.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public List<Deck> Decks { get; set; }
        public List<Collection> Collections { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Reply> Replies { get; set; }

    }
}
