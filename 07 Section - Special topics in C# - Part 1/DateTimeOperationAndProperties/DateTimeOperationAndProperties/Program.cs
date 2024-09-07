// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//
DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

Console.WriteLine(d);
Console.WriteLine("1) Date: " + d.Date);
Console.WriteLine("2) Day: " + d.Day);
Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
Console.WriteLine("5) Hour: " + d.Hour);
Console.WriteLine("6) Kind: " + d.Kind);
Console.WriteLine("7) Millisecond: " + d.Millisecond);
Console.WriteLine("8) Minute: " + d.Minute);
Console.WriteLine("9) Month: " + d.Month);
Console.WriteLine("10) Second: " + d.Second);
Console.WriteLine("11) Ticks: " + d.Ticks);
Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
Console.WriteLine("13) Year: " + d.Year);

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

//
DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);

Console.WriteLine(d1.ToLongDateString());
Console.WriteLine(d1.ToLongDateString());
Console.WriteLine(d1.ToShortDateString());
Console.WriteLine(d1.ToShortTimeString());
Console.WriteLine(d1.ToString());
Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

// 
DateTime d2 = d1.AddHours(2);
DateTime d3 = d1.AddMinutes(3);
DateTime d4 = d1.AddDays(7);

Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

//
DateTime dateTime = new DateTime(2000, 10, 15);
DateTime dateTime1 = new DateTime(2000, 10, 18);

TimeSpan t = dateTime1.Subtract(dateTime);

Console.WriteLine(t);

Console.ReadLine();