namespace BankingModel;

public class Bank
{
    private string BankName { get; set; }
    private List<BankAccount> Accounts;

    public Bank(string bankName)
    {
        this.BankName = bankName;
        Accounts = new();

    }

    public void addAccount(BankAccount account)
    {
        Accounts.Add(account);
    }

    public BankAccount getAccountByNumber(int accountNumber)
    {
        foreach (var i in Accounts)
        {
            if (i.getAccountNumber() == accountNumber)
            {
                return i;
            }
        }

        return null;
    }

    public void transferMoney(int fromAccountNumber, int toAccountNumber, double amount)
    {
        BankAccount foundAccountSender = Accounts.Find(x => x.getAccountNumber() == fromAccountNumber);
        BankAccount foundAccountReceiver = Accounts.Find(x => x.getAccountNumber() == toAccountNumber);
        foundAccountSender.withdraw(amount);
        foundAccountReceiver.deposit(amount);

    }

    public string getBankName()
    {
        return BankName;
    }

    public void getReport(BankAccount account)
    {
        Console.WriteLine("Account number: {0}", account.getAccountNumber());
        Console.WriteLine("Account Holder Name: {0}", account.getAccountHolderName());
        Console.WriteLine("Balance {0}", account.getBalance());
        Console.WriteLine("Bank Name: {0}", BankName);
    }
    
}