namespace BankingModel;

public class BankAccount
{
    public int AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, string accountHolderName)
    {
        this.AccountNumber = accountNumber;
        this.AccountHolderName = accountHolderName;
    }
    
}