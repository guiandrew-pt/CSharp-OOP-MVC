// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using HeritageReview.Entities;

/* BusinessAccount businessAccount = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

Console.WriteLine(businessAccount.Balance); */
// businessAccount.Balance = 200.0; // Error modifier access

//============================================
/* Account account = new Account(1001, "Alex", 0.0);
BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

// Upcasting:
Account account1 = businessAccount;
Account account2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
Account account3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

// Downcasting - We have to test well:
BusinessAccount businessAccount1 = (BusinessAccount)account2;
businessAccount1.Loan(100.0);

// BusinessAccount businessAccount2 = (BusinessAccount)account3; // Error in run time, but do not detects now.
if (account3 is BusinessAccount)
{
    BusinessAccount businessAccount3 = (BusinessAccount)account3;
    businessAccount3.Loan(200.0);
    Console.WriteLine("Loan!");
}

if (account3 is SavingsAccount)
{
    // SavingsAccount savingsAccount = (SavingsAccount)account3;
    // OR:
    SavingsAccount savingsAccount = account3 as SavingsAccount;
    savingsAccount.UpdateBalance();
    Console.WriteLine("Update!");
} */

//============================================
Account account = new Account(1001, "Alex", 500.0);
Account account1 = new SavingsAccount(1002, "Alex", 500.0, 0.01);

account.Withdraw(10.0);
account1.Withdraw(10.0);

Console.WriteLine(account.Balance);
Console.WriteLine(account1.Balance);

Console.ReadLine();