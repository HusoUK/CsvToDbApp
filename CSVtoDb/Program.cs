using CSVtoDb.Data;
using CSVtoDb.Services;
//////////////////////
var watch = System.Diagnostics.Stopwatch.StartNew();

DatabaseServices.Add();

watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine(elapsedMs);

/////////////////////////

//var bookings = DatabaseServices.GetAll();
//int counter = 0;

//foreach (var item in bookings)
//{
//    Console.WriteLine(item.GuestFirstName);
//    counter++;
//}

//Console.WriteLine(counter);

/////////////////////////

//var firstBooking = DatabaseServices.GetFirst();

//Console.WriteLine(firstBooking.GuestFirstName + " " + firstBooking.GuestLastName);

////////////////////////

//Console.WriteLine(DatabaseServices.JsonGetFirst());

/////////////////////


//Console.WriteLine(DatabaseServices.JsonGetAll());

//var bookingsForMonth = DatabaseServices.GetNovember("November");
//int counter2 = 0;

//foreach (var booking in bookingsForMonth)
//{
//    Console.WriteLine($"Checking in on: {booking.CheckIn}, Guest Name: {booking.GuestFirstName}");
//    counter2++;
//}

//Console.WriteLine(counter2);