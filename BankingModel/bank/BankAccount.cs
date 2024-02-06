namespace BankingModel;

public class BankAccount
{
    private int AccountNumber { get; set; }
    private string AccountHolderName { get; set; }
    private double Balance { get; set; }

    public BankAccount(int accountNumber, string accountHolderName)
    {
        this.AccountNumber = accountNumber;
        this.AccountHolderName = accountHolderName;
    }

    public double deposit(double amount)
    {
        this.Balance += amount;
        return this.Balance;

    }

    public double withdraw(double amount)
    {
        this.Balance -= amount;

        if (this.Balance < 0)
            throw new InsufficientFundsException();
        else
        {
            return this.Balance;
        }
    }

    public double getBalance()
    {
        return this.Balance;
    }

    public int getAccountNumber()
    {
        return this.AccountNumber;
    }

    public string getAccountHolderName()
    {
        return this.AccountHolderName;
    }
}