BankAccount account1 = new BankAccount("John Doe", 1000);

// account1.Owner = "John Doe";
// account1.Deposit(1000);

BankAccount account2 = new BankAccount("Jane Doe", 2000);

//account2.Owner = "Jane Doe";
//account2.Deposit(2000);


BankAccount account3 = new BankAccount("Alex", 5000);

//account3.Owner = "Alex";
//account3.Deposit(500);

account2.Deposit(500);
account1.Withdraw(200);
account3.Withdraw(5000);
account1.Withdraw(300);


Console.WriteLine(account1.Owner);
Console.WriteLine(account1.Balance);
Console.WriteLine(account2.Owner);
Console.WriteLine(account2.Balance);
Console.WriteLine(account3.Owner);
Console.WriteLine(account3.Balance);

Console.WriteLine($"account 3: {account3.Owner}, Balance: {account3.Balance}");