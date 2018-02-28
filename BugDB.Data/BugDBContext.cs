using BugDB.BL;
using Microsoft.EntityFrameworkCore;

namespace BugDB.Data
{

    public class BugDBContext : DbContext
    {
        public DbSet<Client> TblClient { get; set; }
        public DbSet<Project> TblProject { get; set; }
        public DbSet<Replicator> TblReplicator { get; set; }
        public DbSet<Email> TblEmail { get; set; }
        public DbSet<Address> TblAddress { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = BugDB; Trusted_Connection = True; ");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity<Client>().Ignore(t => t.IsNew);
            }
        }

    }
}