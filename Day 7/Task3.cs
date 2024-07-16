using System;
abstract class AccountDetails
{
    private string accountNumber;
    private string accountHolderName;
    private static double deposit;
    private static double withdrawal;
    private static double balance;
    private static double interestRate;
    private static string accountType;
    public string GetAccountNumber()
    {
        return accountNumber;
    }
    public void SetAccountNumber(string value)
    {
        accountNumber = value;
    }
    public string GetAccountHolderName()
    {
        return accountHolderName;
    }
    public void SetAccountHolderName(string value)
    {
        accountHolderName = value;
    }
    public static double GetDeposit()
    {
        return deposit;
    }
    public static void SetDeposit(double value)
    {
        deposit = value;
    }
    public static double GetWithdrawal()
    {
        return withdrawal;
    }
    public static void SetWithdrawal(double value)
    {
        withdrawal = value;
    }
    public static double GetBalance()
    {
        return balance;
    }
    public static void SetBalance(double value)
    {
        balance = value;
    }
    public static double GetInterestRate()
    {
        return interestRate;
    }
    public static void SetInterestRate(double value)
    {
        interestRate = value;
    }
    public static string GetAccountType()
    {
        return accountType;
    }
    public static void SetAccountType(string value)
    {
        accountType = value;
    }
    public abstract void DisplayAccountDetails();
}
class ConcreteAccount : AccountDetails
{
    public override void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + GetAccountNumber());
        Console.WriteLine("Account Holder Name: " + GetAccountHolderName());
        Console.WriteLine("Deposit: " + AccountDetails.GetDeposit());
        Console.WriteLine("Withdrawal: " + AccountDetails.GetWithdrawal());
        Console.WriteLine("Balance: " + AccountDetails.GetBalance());
        Console.WriteLine("Interest Rate: " + AccountDetails.GetInterestRate() + "%");
        Console.WriteLine("Account Type: " + AccountDetails.GetAccountType());
    }
}
class Task3
{
    static void Main(string[] args)
    {
        ConcreteAccount account1 = new ConcreteAccount();
        account1.SetAccountNumber("123456789");
        account1.SetAccountHolderName("Sandeep");

        ConcreteAccount account2 = new ConcreteAccount();
        account2.SetAccountNumber("987654321");
        account2.SetAccountHolderName("Shyam");

        AccountDetails.SetDeposit(1000);
        AccountDetails.SetWithdrawal(500);
        AccountDetails.SetBalance(500);
        AccountDetails.SetInterestRate(3.5);
        AccountDetails.SetAccountType("Savings");

        Console.WriteLine("Account 1 Details:");
        account1.DisplayAccountDetails();
        Console.WriteLine();

        Console.WriteLine("Account 2 Details:");
        account2.DisplayAccountDetails();
        Console.WriteLine();
    }
}