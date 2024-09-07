// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

HashSet<int> studentsCourseA = new HashSet<int>();
HashSet<int> studentsCourseB = new HashSet<int>();
HashSet<int> studentsCourseC = new HashSet<int>();

//
Console.Write("How many students for course A: ");
int students = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < students; i++)
{
    int number = Convert.ToInt16(Console.ReadLine());
    studentsCourseA.Add(number);
}

Console.Write("How many students for course B: ");
students = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < students; i++)
{
    int number = Convert.ToInt16(Console.ReadLine());
    studentsCourseB.Add(number);
}

Console.Write("How many students for course C: ");
students = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < students; i++)
{
    int number = Convert.ToInt16(Console.ReadLine());
    studentsCourseC.Add(number);
}

HashSet<int> union = new HashSet<int>(studentsCourseA);
union.UnionWith(studentsCourseB);
union.UnionWith(studentsCourseC);

Console.WriteLine($"Total students: {union.Count}");

Console.ReadLine();