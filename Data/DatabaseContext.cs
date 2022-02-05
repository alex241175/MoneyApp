using Microsoft.EntityFrameworkCore;

namespace MoneyApp.Data
{
   public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options ) : base (options)
        {

        }

        // Specify DbSet properties etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add your own configuration here
              modelBuilder.Entity<Account>()
                .HasMany(x => x.Transactions)
                .WithOne(x => x.Account);    
        }

        public DbSet<User> Users {get;set;}
        public DbSet<Account> Accounts {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
        public DbSet<Routine> Routine {get;set;}
    }
}