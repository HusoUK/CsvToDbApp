using CSVtoDb.Models;
using Microsoft.EntityFrameworkCore;

namespace CSVtoDb.Data
{
    public class BookingsDbContext : DbContext
    {
        public DbSet<BookingModel> Bookings { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var conn = @"Data Source = csvreaderdb.db;";
            var conn = @"Data Source = G:\Huso Storage\Master Apps\My C# projects\GitHub\CsvToDbApp\CsvToDbApp\CSVtoDb\Data\BookingsDb.db;";

            optionsBuilder.UseSqlite(conn);

            base.OnConfiguring(optionsBuilder);
        }

    }
}