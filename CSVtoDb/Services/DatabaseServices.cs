using CSVtoDb.Data;
using CSVtoDb.Models;
using Newtonsoft.Json;
using System.Linq;

namespace CSVtoDb.Services
{
    public static class DatabaseServices
    {
        public static void Add()
        {
            int count = 0;
            var allBookings = BookingsFromCsv.RetrieveBooking();
            using BookingsDbContext ctx = new BookingsDbContext();

            foreach (var booking in allBookings)
            {
                var bookingExists = ctx.Bookings
                    .FirstOrDefault(b => b.BookingReference == booking.BookingReference);

                if (bookingExists == null )
                {
                    ctx.Bookings.Add(booking);
                    count++;
                }
            }
            ctx.SaveChanges();
            Console.WriteLine($"{count} bookings have been added to the database.");
        }

        public static List<BookingModel> GetAll()
        {
            using BookingsDbContext ctx = new BookingsDbContext();

            return ctx.Bookings.ToList();
        }

        public static BookingModel GetFirst()
        {
            using BookingsDbContext ctx = new BookingsDbContext();

            return ctx.Bookings.FirstOrDefault(b => b.Id == 1);
        }
    }
}
