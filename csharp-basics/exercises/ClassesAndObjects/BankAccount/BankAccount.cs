using System;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private decimal _balance;

        public BankAccount(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient funds");
            }
        }

        public string ShowUserNameAndBalance()
        {
            string balanceString = _balance.ToString("0.00");

            if (_balance < 0)
            {
                balanceString = "-" + "$" + (-_balance).ToString("0.00");
            }
            else
            {
                balanceString = "$" + balanceString;
            }

            return _name + ", " + balanceString;
        }
    }
}