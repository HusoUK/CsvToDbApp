using CSVtoDb.Data;
using CSVtoDb.Services;
//////////////////////
var watch = System.Diagnostics.Stopwatch.StartNew();

DatabaseServices.Add();

watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine(elapsedMs);