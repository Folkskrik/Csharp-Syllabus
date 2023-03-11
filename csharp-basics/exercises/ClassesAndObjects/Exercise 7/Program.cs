class Program
{
    static void Main()
    {
        Console.Write("How much money is in the account?: $");
        double startingBalance = double.Parse(Console.ReadLine());

        Console.Write("Enter the annual interest rate: ");
        double annualInterestRate = double.Parse(Console.ReadLine());

        Console.Write("How long has the account been opened? ");
        int numMonths = int.Parse(Console.ReadLine());

        SavingsAccount account = new SavingsAccount(startingBalance, annualInterestRate);

        double totalDeposits = 0;
        double totalWithdrawals = 0;
        double totalInterestEarned = 0;

        for (int i = 1; i <= numMonths; i++)
        {
            Console.Write($"Enter amount deposited for month {i}: $");
            double deposit = double.Parse(Console.ReadLine());
            account.Deposit(deposit);
            totalDeposits += deposit;

            Console.Write($"Enter amount withdrawn for month {i}: $");
            double withdrawal = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawal);
            totalWithdrawals += withdrawal;

            account.AddMonthlyInterest();
            totalInterestEarned += account.GetBalance() - (totalDeposits - totalWithdrawals);

            Console.WriteLine($"Ending balance for month {i}: ${account.GetBalance():F2}\n");
        }

        Console.WriteLine($"Total deposited: ${totalDeposits:F2}");
        Console.WriteLine($"Total withdrawn: ${totalWithdrawals:F2}");
        Console.WriteLine($"Interest earned: ${totalInterestEarned:F2}");
        Console.WriteLine($"Ending balance: ${account.GetBalance():F2}");
    }
}