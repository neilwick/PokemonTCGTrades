using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PokemonTCGTrades.Models
{
    public partial class StoreContext : IdentityDbContext
    {

        public virtual DbSet<Listing> Listings { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        public StoreContext(DbContextOptions<StoreContext> opt) : base(opt) { }
    }
}