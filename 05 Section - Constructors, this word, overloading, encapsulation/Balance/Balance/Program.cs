// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using Balance;

//
Account account;
double amount = 0.0;

//
Console.Write("Type the account number: ");
int number = Convert.ToInt16(Console.ReadLine());

Console.Write("Type the account holder name: ");
string holder = Console.ReadLine();

Console.Write("You want to make a inicial deposit(y/n): ");
char isDeposit = char.Parse(Console.ReadLine());

if (isDeposit == 'y' || isDeposit == 'Y')
{
    Console.Write("Type the inicial deposit: ");
    amount = double.Parse(Console.ReadLine());

    account = new Account(number, holder, amount);
}
else
{
    account = new Account(number, holder);
}

Console.WriteLine();

Console.WriteLine("Account details:");
Console.WriteLine(account);

Console.WriteLine();
Console.Write("Type the amount to make a deposit: ");
amount = double.Parse(Console.ReadLine());

account.Deposit(amount);
Console.WriteLine("Account details updated:");
Console.WriteLine(account);

Console.WriteLine();
Console.Write("Type the amount to make a withdraw: ");
amount = double.Parse(Console.ReadLine());

account.Withdraw(amount);
Console.WriteLine("Account details updated:");
Console.WriteLine(account);

Console.ReadLine();


