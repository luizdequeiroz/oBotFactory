using domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace domain
{
    public class OBotFactoryContext : DbContext
    {
        public OBotFactoryContext(DbContextOptions<OBotFactoryContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Chatter> Chatters { get; set; }
    }
}
