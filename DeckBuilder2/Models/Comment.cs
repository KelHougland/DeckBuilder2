using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder2.Models
{
    public class Comment
    {
        public int ID { get; set; }

        public int DeckID { get; set; }
        public Deck Deck { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public string CommentText { get; set; }

        public List<Reply> Replies { get; set; }

    }
}
