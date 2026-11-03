// SavingsAccount savings =
//     new SavingsAccount("Oomar", 1000m, 0.05m);

// savings.ShowAccountInfo();

// savings.ApplyInterest();

// savings.ShowAccountInfo();

Bank bank = new Bank("YesBank");

CurrentAccount current =
    new CurrentAccount("Oomar", 2000m, 10m);
    
CurrentAccount current2 =
    new CurrentAccount("person1", 2000m, 10m);

SavingsAccount savings =
    new SavingsAccount("John", 1000m, 0.05m);
    
SavingsAccount savings2 =
    new SavingsAccount("person2", 1000m, 0.05m);

bank.AddAccount(current);
bank.AddAccount(current2);
bank.AddAccount(savings);   
bank.AddAccount(savings2);

bank.ShowAllAccounts();


//  polymorphism starts here
List<BankAccount> accounts = new();

accounts.Add(current);
accounts.Add(savings);
accounts.Add(current2);
accounts.Add(savings2);

Console.WriteLine("\n--- Monthly Processing ---");

foreach (BankAccount account in accounts)
{
    account.PerformMonthlyProcessing();
}


Console.WriteLine("\n--- Account Information After Processing ---");

foreach (BankAccount account in accounts)
{
    account.ShowAccountInfo();
}

