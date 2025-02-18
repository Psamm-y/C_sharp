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
        if (Balance-amount< 100)
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
        float interest = Balance * interestRate / 100;
        Console.WriteLine($"Annual Interest: + {interest}");
    }
    //Override account details method from base class
    public virtual void displayAccountDetails()
    {
        base.displayAccountDetails();
        Console.WriteLine($"Interest Rate: {interestRate}");
    }

    //Implementations
    public static void Mains()
    {
        //Create account
        SavingsAccount account = new SavingsAccount("Alice", 
                "SA123", 
                    500,
                0.03f);
        //calling deposit methods on account object
        account.deposit(500); //Deposit 1
        account.deposit(2250,"Hall fees"); //Deposit 2
        
        //Withdraw method
        /*account.Withdraw(4000);
        account.Withdraw(3200);*/
        account.Withdraw(100);
    }
}