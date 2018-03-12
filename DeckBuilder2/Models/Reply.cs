using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder2.Models
{
    public class Reply
    {
        public int ID { get; set; }

        public int CommentID { get; set; }
        public Comment Comment { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public string ReplyContent { get; set; }
    }
}
