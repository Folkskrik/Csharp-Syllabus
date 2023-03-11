using System;

class SavingsAccount
{
    private double balance;
    private double annualInterestRate;

    public SavingsAccount(double startingBalance, double annualInterestRate)
    {
        balance = startingBalance;
        this.annualInterestRate = annualInterestRate;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void AddMonthlyInterest()
    {
        double monthlyInterestRate = annualInterestRate / 12;
        double monthlyInterest = balance * monthlyInterestRate;
        balance += monthlyInterest;
    }

    public double GetBalance()
    {
        return balance;
    }
}