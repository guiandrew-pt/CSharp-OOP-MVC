# 17 Section - Lambda expressions, delegates, LINQ

### Lambda expressions

     • Lambda expressions in C# are used like anonymous functions, with the difference that in Lambda expressions you don’t need to specify the type of the value that you input thus making it more flexible to use.
     The ‘=>’ is the lambda operator which is used in all lambda expressions. The Lambda expression is divided into two parts, the left side is the input and the right is the expression.

     • The Lambda Expressions can be of two types:

          • Expression Lambda: Consists of the input and the expression.
          Syntax:
          input => expression;

          • Statement Lambda: Consists of the input and a set of statements to be executed.
          Syntax:
          input => { statements };

##### Comparison<T> (System)

     • https://msdn.microsoft.com/en-us/library/tfakywbh(v=vs.110).aspx

     • Represents the method that compares two objects of the same type;

     public delegate int Comparison<in T>(T x, T y);

##### List<T>.Sort Method / Sort(Comparison<T>)

     • https://msdn.microsoft.com/en-us/library/w56d4y5z%28v=vs.110%29.aspx

     • Sorts the elements or a portion of the elements in the List<T> using either the specified or default IComparer<T> implementation or a provided Comparison<T> delegate to compare list elements;

### Delegates

     • https://docs.microsoft.com/en-us/dotnet/standard/delegates-lambdas

     • It is a reference (with type safety) to one or more methods:
          • It is a reference type;

     • Common uses:
     • Communication between objects in a flexible and extensible way (events / callbacks);
     • Parameterization of operations by methods (functional programming);

##### Pre-defined delegates

     • Action;
     • Func;
     • Predicate;

##### Multicast delegates

     • Delegates that store the reference to more than one method;
     • To add a reference, you can use the += operator;
     • The Invoke call (or reduced syntax) executes all methods in the order they were added;
     • Its use makes sense for void methods;

##### Predicate (System)

     • Represents a method that receives an object of type T and returns a Boolean value;
          • https://msdn.microsoft.com/en-us/library/bfcke1bz%28v=vs.110%29.aspx

     public delegate bool Predicate<in T>(T obj);

##### Action (System)

     • Represents a void method that takes zero or more arguments;
          • https://msdn.microsoft.com/en-us/library/system.action%28v=vs.110%29.aspx

     public delegate void Action();
     public delegate void Action<in T>(T obj);
     public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
     public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
     (16 overloads)

##### Func (System)

     • Represents a method that takes zero or more arguments, and returns a value;
          • https://msdn.microsoft.com/en-us/library/bb534960%28v=vs.110%29.aspx

     public delegate TResult Func<out TResult>();
     public delegate TResult Func<in T, out TResult>(T obj);
     public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
     public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
     (16 overloads)

##### Note about the Select function

     • The "Select" function (belonging to LINQ) is a function that applies a function to all elements of a collection, thus generating a new collection (of type IEnumerable);

     List<int> numbers = new List<int> { 2, 3, 4 };
     IEnumerable<int> newList = numbers.Select(x => 2 * x);
     Console.WriteLine(string.Join(" ", newList));
     4 6 8

### LINQ - Language Integrated Query

     • It is a set of technologies based on the integration of query functionalities directly into the C# language:
          • Operations called directly from collections;
          • Queries are first-class objects;
          • IDE Compiler and IntelliSense Support;

     • Namespace: System.Linq;

     • It has several query operations, whose parameters are typically lambda expressions or expressions with a syntax similar to SQL;

     • Reference:
          • https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/index

##### LINQ Operations / References

     • Filtering: Where, OfType;
     • Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse;
     • Set:Distinct,Except,Intersect,Union;
     • Quantification: All, Any, Contains;
     • Projection: Select, SelectMany;
     • Partition:Skip,Take;
     • Join: Join, GroupJoin;
     • Grouping: GroupBy;
     • Generational: Empty;
     • Equality:SequenceEquals;
     • Element:ElementAt,First,FirstOrDefault Last, LastOrDefault, Single, SingleOrDefault;
     • Conversions: AsEnumerable, AsQueryable • Concatenation:Concat;
     • Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum;

##### References

     • https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/introduction-to-linq-queries
