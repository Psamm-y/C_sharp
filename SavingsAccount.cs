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
}