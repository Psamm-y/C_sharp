namespace Csharp_projects.Tasks;

public class BankAccount
{
    protected String accountHoldername;
    protected String accountNumber;
    protected float balance;

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
       Console.WriteLine($"Deposited ${amount} successfully as {note}. Account balance: ${balance}");
    }

    public void Withdraw(float amount)
    {
        if (balance >= amount)
        {
            balance-= amount;
            Console.WriteLine($"Withdrawn ${amount} successfully. Available account balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
}