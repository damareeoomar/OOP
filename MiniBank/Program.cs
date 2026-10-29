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

