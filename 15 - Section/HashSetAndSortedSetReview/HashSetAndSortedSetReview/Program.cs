// Console.WriteLine("Hello, World!");

//
/* HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Notebook"));
Console.WriteLine(set.Contains("Note"));

foreach (string str in set)
{
    Console.WriteLine(str);
}
*/

internal class Program
{
    private static void Main(string[] args)
    {
        //
        SortedSet<int> ints1 = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10 };
        SortedSet<int> ints2 = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

        // PrintCollection(ints1);

        // Union:
        SortedSet<int> ints3 = new SortedSet<int>(ints1);
        ints3.UnionWith(ints2);

        PrintCollection(ints3);

        // Intersection:
        SortedSet<int> ints4 = new SortedSet<int>(ints1);
        ints4.IntersectWith(ints2);

        PrintCollection(ints4);

        // Difference:
        SortedSet<int> ints5 = new SortedSet<int>(ints1);
        ints5.ExceptWith(ints2);

        PrintCollection(ints5);

        Console.ReadLine();
    }

    public static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.Write(obj + " ");
        }

        Console.WriteLine();
    }
}