namespace Csharp_projects.Tasks;

public class SavingsAccount : BankAccount
{
    private float interestRate;

    //Constructor with superclass initialized attributes
    public SavingsAccount(String accountHoldername,
                            String accountNumber, 
                            float balance,
                            float interestRate)
    : base (accountHoldername, accountNumber, balance)
    {
        this.interestRate = interestRate;
    }

    //Override withdraw method from base class
    public void Withdraw(float amount)
    {
        if (balance-amount< 100)
        {
            Console.WriteLine("Withdrawal declined.");
        }
        else
        {
            base.Withdraw(amount);
        }
    }

    public void CalculateInterest()
    {
        float interest = balance * interestRate / 100;
        Console.WriteLine($"Annual Interest: + {interest}");
    }
    //Override account details method from base class
    public virtual void displayAccountDetails()
    {
        base.displayAccountDetails();
        Console.WriteLine($"Interest Rate: {interestRate}");
    }

    //Implementations
    public static void Program(string[] args)
    {
        SavingsAccount account = new SavingsAccount("Alice", "SA123", 500, 0.03f);
    }
}