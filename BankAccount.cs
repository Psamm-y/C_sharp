namespace Csharp_projects.Tasks;

public class BankAccount
{
    private String accountHoldername;
    private String accountNumber;
    private float balance;

    public BankAccount(String accountHoldername, String accountNumber, float balance)
    {
        this.accountHoldername = accountHoldername;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void deposit(float amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited ${amount} successfully. Account balance: ${balance}");
    }

    public void deposit(float amount, String note)
    {
       balance += amount;
    }
}