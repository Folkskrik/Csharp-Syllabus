using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            bartosAccount.Deposit(20.0);
            Console.WriteLine(bartosAccount);

            Account mattsAccount = new Account("Matt's account", 1000.0);
            Account myAccount = new Account("My account", 0.0);
            mattsAccount.Withdrawal(100.0);
            myAccount.Deposit(100.0);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            Account accountA = new Account("A", 100.0);
            Account accountB = new Account("B", 0.0);
            Account accountC = new Account("C", 0.0);

            Transfer(accountA, accountB, 50.0);
            Transfer(accountB, accountC, 25.0);

            Console.WriteLine(accountA);
            Console.WriteLine(accountB);
            Console.WriteLine(accountC);
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}