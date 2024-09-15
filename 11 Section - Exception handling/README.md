# 11 Section - Exception handling

      - This section was a recap to exception handlings in C#.

### Exceptions

    • An exception is any error condition or unexpected behavior encountered by a running program;
    • In .NET, an exception is an object inherited from the System.Exception class;
    • When thrown, an exception is propagated up the call stack of running methods until it is caught (handled) or the program is terminated;

### Why exceptions?

    • The exception handling model allows errors to be handled in a consistent and flexible way, using best practices;
    • Advantages:
      • Delegates the error logic to the class/method responsible for knowing the rules that can cause the error;
      • Handles exceptions of different types in an organized (including hierarchical) manner;
      • The exception can carry any data;
