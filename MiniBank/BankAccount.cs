public class BankAccount
{
    public string Owner { get; set; }   
    public decimal Balance { get; private set; }  // private set for encapsulation. 

    //Constructor (same name as the class + no return type)
    public BankAccount(string owner, decimal startingBalance)
    {
        Owner = owner;
        Balance = startingBalance;
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