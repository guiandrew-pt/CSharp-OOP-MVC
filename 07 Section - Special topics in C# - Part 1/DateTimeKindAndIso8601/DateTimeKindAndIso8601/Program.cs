// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);

Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

Console.WriteLine("d1: " + d1);
Console.WriteLine("d1 Kind: " + d1.Kind);
Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

Console.WriteLine("d2: " + d2);
Console.WriteLine("d2 Kind: " + d2.Kind);
Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());

Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

Console.WriteLine("d3: " + d3);
Console.WriteLine("d3 Kind: " + d3.Kind);
Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

//
DateTime dateTime = DateTime.Parse("2000-08-15 13:05:58");
DateTime dateTime1 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine("dateTime: " + dateTime);
Console.WriteLine("dateTime Kind: " + dateTime.Kind);
Console.WriteLine("dateTime to Local: " + dateTime.ToLocalTime());
Console.WriteLine("dateTime to UTC: " + dateTime.ToUniversalTime());
Console.WriteLine("------------------");
Console.WriteLine("dateTime1: " + dateTime1);
Console.WriteLine("dateTime1 Kind: " + dateTime1.Kind);
Console.WriteLine("dateTime1 to Local: " + dateTime1.ToLocalTime());
Console.WriteLine("dateTime1 to UTC: " + dateTime1.ToUniversalTime());
Console.WriteLine();
Console.WriteLine(dateTime1.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Careful! -> Wrong!!!
Console.WriteLine(dateTime1.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Correct!!

Console.ReadLine();