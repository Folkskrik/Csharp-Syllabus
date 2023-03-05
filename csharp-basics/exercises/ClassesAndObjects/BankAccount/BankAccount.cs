using System;

namespace BankAccount
{
    class BankAccount
    {
        private string name;
        private decimal balance;

        public BankAccount(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient funds");
            }
        }

        public string ShowUserNameAndBalance()
        {
            string balanceString = balance.ToString("0.00");

            if (balance < 0)
            {
                balanceString = "-" + "$" + (-balance).ToString("0.00");
            }
            else
            {
                balanceString = "$" + balanceString;
            }

            return name + ", " + balanceString;
        }
    }
}