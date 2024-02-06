namespace BankingModel;

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException()
    {
        Console.WriteLine("An error occured due to insufficient funds in the account: " + base.Message);
    }
}