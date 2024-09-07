// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using BankBalance.Entities;
using BankBalance.Entities.Exceptions;

//
try
{
    Console.WriteLine("Enter account data:");
    Console.Write("Number: ");
    int number = Convert.ToInt16(Console.ReadLine());

    Console.Write("Holder: ");
    string holder = Console.ReadLine();

    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine());

    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(number, holder, initialBalance, withdrawLimit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amountWithdraw = double.Parse(Console.ReadLine());

    account.Withdraw(amountWithdraw);

    Console.WriteLine(account);
}
catch (DomainException ex)
{
    Console.WriteLine($"Withdraw error: {ex.Message}");
}
catch (FormatException ex)
{
    Console.WriteLine("Format error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}

Console.ReadLine();