public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; private set; }
    public SavingsAccount(string owner, decimal balance, decimal interestRate) : base(owner, balance)
    {
        InterestRate = interestRate;
        Console.WriteLine("SavingsAccount constructor executed");
    }

    public void ShowAccountType()
    {
        Console.WriteLine($"Account type: {AccountType}");
    }
}