// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Globalization;
using PaymentServiceInterface.Entities;
using PaymentServiceInterface.Services;

//
Console.WriteLine("Enter contract data:");

Console.Write("Number: ");
int contractNumber = Convert.ToInt16(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());

Console.Write("Enter number of installments: ");
int numberInstallments = Convert.ToInt16(Console.ReadLine());

Contract contract = new Contract(contractNumber, contractDate, contractValue);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, numberInstallments);

Console.WriteLine();
Console.WriteLine("INSTALLMENTS:");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}

Console.ReadLine();