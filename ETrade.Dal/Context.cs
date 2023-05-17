using ETrade.Ent;
using Microsoft.EntityFrameworkCore;

namespace ETrade.Dal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> op) : base(op)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>()
                .HasKey(o => new { o.OrderId, o.FoodId });
        }

        // DbSets

        public DbSet<Users> Users { get; set; }

        public DbSet<Foods> Foods { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}