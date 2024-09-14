# 07 Section - Special topics in C# - Part 1

      - This section was a recap special topics in C#.

### Type inference: keyword var

    - The var keyword instructs the compiler to infer the type of the variable from the expression on the right side of the initialization statement;

    - C# 3.0 introduced a var keyword that can be used to declare implicit types. The purpose of implicit types is to store any type in a variable;

    - The feature is called type inference;

    Example:

    var x = 10;
    var y = 20.0;
    var z = "Bruce";

### Alternative syntax: switch-case

    - Optional structure to several chained if-else, when the condition involves testing the value of a variable;

    Example:

    int x = int.Parse(Console.ReadLine()); string day;
    switch (x) {
      case 1:
        day = "Sunday";
        break;
      case 2:
        day = "Monday";
        break;
      case 3:
        day = "Tuesday";
        break;
      case 4:
        day = "Wednesday";
        break;
      case 5:
        day = "Thursday";
        break;
      case 6:
        day = "Friday";
        break;
      case 7:
        day = "Saturday";
        break;
      default:
        day = "Invalid value";
        break;
    }

    Console.WriteLine("Day: " + day);

### Ternary conditional expression

    - In short words, is a short-hand if else. It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements;

    Example:

    double price = 34.5;
    double discount = (price < 20.0) ? price * 0.1 : price * 0.05;
    -                 Condition      ?  true        :    false

### Interesting string functions

    • Format: ToLower(), ToUpper(), Trim();
    • Search: IndexOf, LastIndexOf;
    • Crop: Substring(inicio), Substring(inicio, tamanho);
    • To replace: Replace(char, char), Replace(string, string);
    • String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str);
    • str.Split(' ');
    • Conversion to number: int x = int.Parse(str), int x =Convert.ToInt32(str);
    • Number Conversion: str = x.ToString(), str = x.ToString("C"), str = x.ToString("C3"), str = x.ToString("F2");

### DateTime

    - Represents an INSTANT;
    - It is a value type (struct);
    - Agenda:
      • Internal representation
      • Instantiation: constructors, builders / String conversion -> DateTime
      • Formatting: DateTime -> String
    - Internal representation:
      • A DateTime object internally stores:
        • The number of "ticks" (100 nanoseconds) since midnight on the 1st of January of Year 1 of the Common Era;

    - Instantiation:
      • Constructors:
        • DateTime(year, month, day);
        • DateTime(year, month, day, hour, minute, second) [optional: kind];
        • DateTime(year, month, day, hour, minute, second, millisecond) [optional: kind];


    - Builders:
      • DateTime.Now;
      • DateTime.UtcNow;
      • DateTime.Today[time:00:00:00];
      • DateTime.Parse(string);
      • DateTime.ParseExact(string,string);

    - Properties and Operations with DateTime:
      • Propriedades:
        • Date(DateTime);
        • Day (int);
        • DayOfWeek(DayOfWeek);
        • DayOfYear(int);
        • Hour(int);
        • Kind(DateTimeKind);
        • Millisecond(int);
        • Minute(int);
        • Month(int);
        • Second(int);
        • Ticks(long);
        • TimeOfDay(TimeSpan);
        • Year(int);

### TimeSpan

    • Represents a DURATION;
    • It is a value type (struct);
    • Agenda:
      • Internal representation;
      • Instantiation: constructors, fields, From methods, Parse;

    • Internal representation:
      • A TimeSpan object internally stores a duration in the form of ticks (100 nanoseconds);

    • Constructors:
      • TimeSpan();
      • TimeSpan(ticks);
      • TimeSpan(horas, minutos, segundos);
      • TimeSpan(dias, horas, minutos, segundos);
      • TimeSpan(dias, horas, minutos, segundos, milissegundos);

    - Properties and Operations with TimeSpan:
      • Days;
      • Hours;
      • Milliseconds;
      • Minutes;
      • Seconds;
      • Ticks;
      • TotalDays;
      • TotalHours;
      • TotalMilliseconds;
      • TotalMinutes;
      • TotalSeconds;
