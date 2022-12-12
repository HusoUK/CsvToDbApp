using CSVtoDb.Models;
using LINQtoCSV;

namespace CSVtoDb.Services
{
    public class BookingsFromCsv
    {
        public static List<BookingModel> RetrieveBooking()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var csvDirectory = Path.Combine(currentDirectory, "CSVFiles");
            var csvFoundFiles = FindFiles(csvDirectory);

            var bookingListForAllFiles = new List<BookingModel>();

            foreach (var file in csvFoundFiles)
            {
                var bookingsInEachFile = CsvToListOfBookings(file);

                foreach (var booking in bookingsInEachFile)
                {
                    bookingListForAllFiles.Add(booking);
                }
            }
            return bookingListForAllFiles;
        }

        public static List<BookingModel> CsvToListOfBookings(string file)
        {
            var inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true
            };
            var context = new CsvContext();
            var bookings = context.Read<BookingModel>(file, inputFileDescription);

            return bookings.ToList();
        }

        public static IEnumerable<string> FindFiles(string foldName)
        {
            List<string> csvfiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(foldName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
            {
                var extension = Path.GetExtension(file);
                if (extension == ".csv")
                {
                    csvfiles.Add(file);
                }
            }
            return csvfiles;
        }
    }
}
