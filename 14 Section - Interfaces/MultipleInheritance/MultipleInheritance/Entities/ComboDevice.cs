using MultipleInheritance.Entities.Interfaces;

namespace MultipleInheritance.Entities
{
    public class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice print {document}");
        }

        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice processing {document}");
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}

