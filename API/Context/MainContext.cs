using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Context
{
    public class MainContext: DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<LogDeparture> LogDeparture { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Driver>().ToTable("Driver");
            modelBuilder.Entity<Flight>().ToTable("Flight");
            modelBuilder.Entity<LogDeparture>().ToTable("LogDeparture");
        }
    }
}
