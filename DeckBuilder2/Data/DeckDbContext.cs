using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DeckBuilder2.Data
{
    public class DeckDbContext : DbContext
    {


        public DeckDbContext(DbContextOptions<DeckDbContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        
    }
}
