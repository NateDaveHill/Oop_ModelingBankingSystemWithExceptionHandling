
using System.IO.Compression;
using BankingModel;

Bank newBank = new Bank("HillTestingBank");
BankAccount newBankAccountOne = new BankAccount(12345, "Nathan");
BankAccount newBankAccountTwo = new BankAccount(67890, "Staree");

newBank.addAccount(newBankAccountOne);
newBank.addAccount(newBankAccountTwo);

newBankAccountOne.deposit(100);

newBankAccountTwo.deposit(5);

newBank.getReport(newBankAccountOne);
newBank.getReport(newBankAccountTwo);


newBank.getBankName();
newBank.getAccountByNumber(12345);
newBank.getAccountByNumber(67890);

try
{
    newBank.transferMoney(67890, 12345, 10);
    
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine("An error occured due to insufficient funds in the account: " + ex.Message);
}

newBank.getReport(newBankAccountOne);
newBank.getReport(newBankAccountTwo);