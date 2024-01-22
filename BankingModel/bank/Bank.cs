namespace BankingModel;

public class Bank
{
    public string BankName { get; set; }
    public List<BankAccount> Accounts { get; set; }

    public Bank(string bankName, List<BankAccount> accounts)
    {
        this.BankName = bankName;
        this.Accounts = accounts;

    }
}