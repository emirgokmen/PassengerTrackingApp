using Microsoft.EntityFrameworkCore;
using PassengerTrackingApp.Models;

namespace PassengerTrackingApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Bu satır SQL Server'da "Passengers" adında bir tablo oluşturur
        public DbSet<Passenger> Passengers { get; set; }
    }
}