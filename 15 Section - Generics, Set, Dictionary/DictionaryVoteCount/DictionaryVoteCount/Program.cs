// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
string source = "/Applications/Study/Udemy/05 - C# COMPLETO Programação Orientada a Objetos + Projetos/15 - Section 15/File/votes.txt";

//
Dictionary<string, int> electedVotes = new Dictionary<string, int>();

Console.Write("Enter the full path: ");
string? path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int votes = Convert.ToInt16(line[1]);

            if (electedVotes.ContainsKey(name))
            {
                electedVotes[name] += votes;
            }
            else
            {
                electedVotes[name] = votes;
            }
        }

        Console.WriteLine();

        foreach (KeyValuePair<string, int> keyValuePair in electedVotes)
        {
            Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();