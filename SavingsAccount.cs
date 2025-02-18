namespace Csharp_projects.Tasks;

public class SavingsAccount : BankAccount
{
    private float interestRate;

    //Constructor with superclass initialized attributes
    public SavingsAccount(float interestRate,
                            String accountHoldername,
                            String accountNumber, 
                            float balance)
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
        Console.WriteLine($"Anual Interest: + {interest}");
    }
}