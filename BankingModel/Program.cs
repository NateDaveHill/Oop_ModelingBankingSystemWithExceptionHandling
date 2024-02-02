
using System.IO.Compression;
using BankingModel;

Bank newBank = new Bank("HillTestingBank");
BankAccount newBankAccountOne = new BankAccount(12345, "Nathan");
BankAccount newBankAccountTwo = new BankAccount(67890, "Staree");


newBank.addAccount(newBankAccountOne);
newBank.addAccount(newBankAccountTwo);

newBankAccountOne.deposit(100);

newBankAccountTwo.deposit(100);

newBank.getReport(newBankAccountOne);
newBank.getReport(newBankAccountTwo);

// newBank.getReport(newBankAccountOne);
// newBank.getReport(newBankAccountTwo);

// Console.WriteLine(newBank.getBankName());

newBank.getBankName();
newBank.getAccountByNumber(12345);
newBank.getAccountByNumber(67890);
newBank.transferMoney(12345, 67890, 10);
newBank.getReport(newBankAccountOne);
newBank.getReport(newBankAccountTwo);
