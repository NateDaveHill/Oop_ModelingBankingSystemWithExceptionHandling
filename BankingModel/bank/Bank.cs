namespace BankingModel;

public class Bank
{
    public string BankName { get; set; }
    public List<BankAccount>? Accounts { get; set; }

    public Bank(string bankName, List<BankAccount>? accounts)
    {
        this.BankName = bankName;
        this.Accounts = accounts;

    }
    public Bank(string bankName)
    {
        this.BankName = bankName;
    }

    public void addAccount(BankAccount account)
    {
        Accounts.Add(account);
    }

    public BankAccount getAccountByNumber(int accountNumber)
    {
        foreach (var i in Accounts)
        {
            if (i.AccountNumber == accountNumber)
            {
                return i;
            }
        }

        return null;
    }

    public void transferMoney(int fromAccountNumber, int toAccountNumber, double amount)
    {
        BankAccount foundAccountSender = Accounts.Find(x => x.AccountNumber == fromAccountNumber);
        BankAccount foundAccountReceiver = Accounts.Find(x => x.AccountNumber == toAccountNumber);
        foundAccountSender.withdraw(amount);
        foundAccountReceiver.deposit(amount);

    }

    public string getBankName()
    {
        return BankName;
    }

    public void getReport(BankAccount account)
    {
        Console.WriteLine("Account number: {0}", account.AccountNumber);
        Console.WriteLine("Account Holder Name: {0}", account.AccountHolderName);
        Console.WriteLine("Balance {0}", account.Balance);
        Console.WriteLine("Bank Name: {0}", BankName);
    }
    
}