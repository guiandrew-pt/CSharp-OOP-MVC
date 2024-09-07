// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using System.Globalization;

DateTime d1 = DateTime.Now;

Console.WriteLine(d1);
Console.WriteLine(d1.Ticks);

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();

//
DateTime d2 = new DateTime(2023, 11, 25);
DateTime d3 = new DateTime(2023, 11, 25, 20, 45, 3);
DateTime d4 = new DateTime(2023, 11, 25, 20, 45, 3, 500);

DateTime d5 = DateTime.Today;
DateTime d6 = DateTime.UtcNow;

Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();

//
DateTime date = DateTime.Parse("2000-08-15"); // Month is frist, next day;
DateTime date1 = DateTime.Parse("2000-08-15 13:05:58");
DateTime date2 = DateTime.Parse("08/15/2000");
DateTime date3 = DateTime.Parse("08/15/2000 13:05:27");

Console.WriteLine(date);
Console.WriteLine(date1);
Console.WriteLine(date2);
Console.WriteLine(date3);

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();

//
DateTime date4 = DateTime.ParseExact("2020-08-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InstalledUICulture);
DateTime date5 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InstalledUICulture);

Console.WriteLine(date4);
Console.WriteLine(date5);



Console.ReadLine();