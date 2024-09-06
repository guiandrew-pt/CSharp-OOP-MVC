// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
TimeSpan t1 = TimeSpan.MaxValue;
TimeSpan t2 = TimeSpan.MinValue;
TimeSpan t3 = TimeSpan.Zero;

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);

Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();

//
TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

Console.WriteLine(t);
Console.WriteLine("Days: " + t.Days);
Console.WriteLine("Hours: " + t.Hours);
Console.WriteLine("Minutes: " + t.Minutes);
Console.WriteLine("Milliseconds: " + t.Milliseconds);
Console.WriteLine("Seconds: " + t.Seconds);
Console.WriteLine("Ticks: " + t.Ticks);

Console.WriteLine("TotalDays: " + t.TotalDays);
Console.WriteLine("TotalHours: " + t.TotalHours);
Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();

//
TimeSpan timeSpan = new TimeSpan(1, 30, 10);
TimeSpan timeSpan1 = new TimeSpan(0, 10, 5);

TimeSpan sum = timeSpan.Add(timeSpan1);
TimeSpan dif = timeSpan.Subtract(timeSpan1);
TimeSpan mult = timeSpan1.Multiply(2.0);
TimeSpan div = timeSpan1.Divide(2.0);

Console.WriteLine(sum);
Console.WriteLine(dif);
Console.WriteLine(mult);
Console.WriteLine(div);


Console.ReadLine();