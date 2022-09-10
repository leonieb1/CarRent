namespace CarRent.Repository
{
    using Microsoft.EntityFrameworkCore;
    using CarRent.Repository.Tables;
    public class CarRentContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Verbindung aufbauen
            optionsBuilder.UseSqlServer(
                "Data Source=.; Database=CarRent; Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();

            // Logs
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}