namespace Csharp_projects.Tasks;

public class BankAccount
{
    private String accountHoldername;
    private String accountNumber;
    private float balance;

    public String AccountHolderName { get; set; }
    public String AccountNumber { get; set; }
    public float Balance { get; set; }
    public BankAccount(String accountHoldername, String accountNumber, float balance)
    {
        this.accountHoldername = accountHoldername;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    //overloading deposit method
    public void deposit(float amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited ${amount} successfully. Account balance: ${Balance}");
    }

    public void deposit(float amount, String note)
    {
       Balance += amount;
       Console.WriteLine($"Deposited ${amount} successfully as {note}. Account balance: ${Balance}");
    }

    public void Withdraw(float amount)
    {
        if (Balance >= amount)
        {
            Balance-= amount;
            Console.WriteLine($"Withdrawn ${amount} successfully. Available account balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public virtual void displayAccountDetails()
    {
        Console.WriteLine($"Account holder name: {accountHoldername}");
        Console.WriteLine($"Account number: {accountNumber}");
        Console.WriteLine($"Current Balance: {balance} \n");
    }
}