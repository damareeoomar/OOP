public class Bank
{
    public string Name { get; private set; }

    private List<BankAccount> accounts = new List<BankAccount>();

    public Bank(string name)
    {
        Name = name;
    }

    public void AddAccount(BankAccount account)
    {
        accounts.Add(account);
    }

    public void ShowAllAccounts()
    {
        foreach (BankAccount account in accounts)
        {
            account.ShowAccountInfo();
        }
    }
}