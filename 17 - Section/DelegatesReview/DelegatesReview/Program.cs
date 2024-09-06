// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using DelegatesReview.Services;

namespace DelegatesReview
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationvoid(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // BinaryNumericOperation binary = new BinaryNumericOperation(CalculationService.Max);
            BinaryNumericOperation binary = CalculationService.Max;
            // double result = binary(a, b);
            double result = binary.Invoke(a, b);

            Console.WriteLine(result);
            Console.WriteLine("====================================");
            // ====================================
            BinaryNumericOperationvoid binaryNumeric = CalculationService.ShowSum;
            binaryNumeric += CalculationService.ShowMax;

            // binaryNumeric.Invoke(a, b);
            binaryNumeric(a, b);

            Console.ReadLine();
        }
    }
}




