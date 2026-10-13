// BankAccount account1 = new BankAccount("John Doe", 1000);

// // account1.Owner = "John Doe";
// // account1.Deposit(1000);

// BankAccount account2 = new BankAccount("Jane Doe", 0);

// //account2.Owner = "Jane Doe";
// //account2.Deposit(2000);


// BankAccount account3 = new BankAccount("Alex", 5000);

// //account3.Owner = "Alex";
// //account3.Deposit(500);

// // account2.Deposit(500);
// // account1.Withdraw(200);
// // account3.Withdraw(5000);
// // account1.Withdraw(300);


// // Console.WriteLine(account1.Owner);
// // Console.WriteLine(account1.Balance);
// // Console.WriteLine(account2.Owner);
// // Console.WriteLine(account2.Balance);
// // Console.WriteLine(account3.Owner);
// // Console.WriteLine(account3.Balance);

// // Console.WriteLine($"account 3: {account3.Owner}, Balance: {account3.Balance}");

// Console.WriteLine($"Owner: {account1.Owner}, Balance: {account1.Balance}");
// Console.WriteLine($"Owner: {account2.Owner}, Balance: {account2.Balance}");
// // account1.ShowAccountInfo(account1);
// // account2.ShowAccountInfo(account2);
// account3.ShowAccountInfo();
// BankAccount.ShowBankInfo();




/////////////////////////////////////////////////////////////////////////////////

//Bank object part 

// Bank bank = new Bank("MiniBank");

// BankAccount account1 = new BankAccount("John Doe", 1000);
// BankAccount account2 = new BankAccount("Jane Doe", 2000);

// bank.AddAccount(account1);
// bank.AddAccount(account2);

// bank.ShowAllAccounts();

Bank bank = new Bank("MiniBank");

BankAccount account1 = new BankAccount("John Doe", 1000);
BankAccount account2 = new BankAccount("Jane Doe", 2000);

bank.AddAccount(account1);
bank.AddAccount(account2);

Console.WriteLine("BEFORE DEPOSIT:");
bank.ShowAllAccounts();

account1.Deposit(500);

Console.WriteLine("\nAFTER DEPOSIT:");
bank.ShowAllAccounts();