# 16 Section - Special topics in C# - Part 2

### Extension methods

     • They are methods that extend the functionality of a type, without having to change the source code of this type, nor inheriting from this type;

     • How to make an extension method?
      • Create a static class;
      • In the class, create a static method;
      • The first parameter of the method must have the prefix this, followed by the declaration of a parameter of the type you want to extend. This will be a reference to the object itself;
