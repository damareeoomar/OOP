public class BankAccount
{
    public static int TotalAccounts { get; private set; }
    public string Owner { get; private set; }   
    public decimal Balance { get; private set; }  // private set for encapsulation. 
    protected string AccountType = "General";  // change to private to see the effect on encapsulationon in herited classes(build fails)

    //Constructor (same name as the class + no return type)
    // public BankAccount(string owner, decimal startingBalance)
    // {
    //     Owner = owner;
    //     Balance = startingBalance;
    // }
    public BankAccount(string owner, decimal startingBalance)   // using 'this' keyword for clarity. this refer to the current object instance.
    {
        if (string.IsNullOrWhiteSpace(owner))
        {
            throw new ArgumentException("Owner name cannot be empty.");
        }

        if (startingBalance < 0)
        {
            throw new ArgumentException("Starting balance cannot be negative.");
        }

        this.Owner = owner;
        this.Balance = startingBalance;
        TotalAccounts++;
        Console.WriteLine("BankAccount constructor executed");
    }

    public static void ShowBankInfo()
    {
        Console.WriteLine("Welcome to MiniBank!");
        Console.WriteLine($"Total accounts created: {TotalAccounts}");
    }
    // public  void ShowAccountInfo(BankAccount account)  //this is incorrect because someone can just write "account1.ShowAccountInfo(account3);"
    // {
    //     Console.WriteLine("Account Information:");
    //     Console.WriteLine($"Owner: {account.Owner}");
    //     Console.WriteLine($"Balance: {account.Balance}");
    // }

    public virtual void ShowAccountInfo() // this is the correct way to show account info for the current instance
    {
        Console.WriteLine("Account Information:");
        Console.WriteLine($"Owner: {this.Owner}");
        Console.WriteLine($"Balance: {this.Balance}");
    }


    // methods 
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }
}