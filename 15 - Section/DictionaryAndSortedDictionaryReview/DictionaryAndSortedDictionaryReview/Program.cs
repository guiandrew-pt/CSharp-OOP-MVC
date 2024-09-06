// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "99712234";
cookies["phone"] = "83737388";

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'email' key!");
}

Console.WriteLine($"Size: {cookies.Count}");

Console.WriteLine("ALL COOKIES:");
foreach (KeyValuePair<string, string> keyValuePair in cookies)
{
    Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
}

Console.ReadLine();