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

    public double deposit(double amount)
    {
        double newBalance = this.Balance + amount;
        return newBalance;

    }

    public double withdraw(double amount)
    {
        double newBalance = this.Balance - amount;
        return newBalance;
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