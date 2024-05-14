using DRHanannProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DRHanannProject
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<alexWeatherData> alexWeatherData { get; set; }
        public DbSet<AswanweatherData> aswanweatherData { get; set; }
        public DbSet<cairoWeatherData> cairoWeatherData { get; set; }
        public DbSet<tantaWeatherData> tantaWeatherData { get; set; }
        public DbSet<suezWeatherData> suezWeatherData { get;set; }
        public DbSet<user> users { get; set; }
        public DbSet<modules> modules { get; set; }
        public DbSet<power> power { get; set; }

    }
}
