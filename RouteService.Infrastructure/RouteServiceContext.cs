using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RouteService.Domain.Entities;

namespace RouteService.Infrastructure
{
    public class RouteServiceContext : DbContext
    {
        private readonly string _connectionString;
        public RouteServiceContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("RouteServiceContext") ?? string.Empty;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Route>().HasKey(l => l.Id);
            modelBuilder.Entity<Booking>().HasKey(l => l.Id);
            modelBuilder.Entity<Seat>().HasKey(l => l.Id);
            modelBuilder.Entity<Route>().HasKey(l => l.Id);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.From)
                .WithMany()
                .HasForeignKey(b => b.From.Id)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.To)
                .WithMany()
                .HasForeignKey(b => b.To.Id)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
