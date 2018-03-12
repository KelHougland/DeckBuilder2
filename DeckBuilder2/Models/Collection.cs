using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder2.Models
{
    public class Collection
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<CardCollection> CardCollections { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

    }
}
