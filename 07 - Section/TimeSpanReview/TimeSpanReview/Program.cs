// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
TimeSpan timeSpan = new TimeSpan(0, 1, 30);

Console.WriteLine(timeSpan);
Console.WriteLine(timeSpan.Ticks);

Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();

//
TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(900000000L);
TimeSpan t3 = new TimeSpan(2, 11, 21);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321, 500);

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);
Console.WriteLine(t6);

Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();

//
TimeSpan time1 = TimeSpan.FromDays(1.5);
TimeSpan time2 = TimeSpan.FromHours(1.5);
TimeSpan time3 = TimeSpan.FromMinutes(1.5);
TimeSpan time4 = TimeSpan.FromSeconds(1.5);
TimeSpan time5 = TimeSpan.FromMilliseconds(1);
TimeSpan time6 = TimeSpan.FromTicks(900000000L);

Console.WriteLine(time1);
Console.WriteLine(time2);
Console.WriteLine(time3);
Console.WriteLine(time4);
Console.WriteLine(time5);
Console.WriteLine(time6);

Console.ReadLine();