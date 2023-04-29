using Estadio.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estadio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Ticket { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            //modelBuilder.Entity<State>().HasIndex("CountryId", "Name").IsUnique();
            //modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();
            //modelBuilder.Entity<Category>().HasIndex(x => x.Name).IsUnique();
            //modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique();           
        }
    }
}
