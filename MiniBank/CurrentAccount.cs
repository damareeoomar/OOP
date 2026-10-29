public class CurrentAccount : BankAccount
{
    public decimal TransactionFee { get; private set; }

    public CurrentAccount(string owner, decimal balance, decimal transactionFee) : base(owner, balance)
    {
        this.TransactionFee = transactionFee;
        Console.WriteLine("CurrentAccount constructor executed");
    }

    public override void ShowAccountInfo()
    {
        base.ShowAccountInfo();
        Console.WriteLine($"Transaction Fee: {TransactionFee:C}");
    }
}