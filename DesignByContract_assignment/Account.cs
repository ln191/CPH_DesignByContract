using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignByContract_assignment
{
    public class Account
    {
        private double balance = 1000.00;
        public double Balance { get; }

        public Account()
        {
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error:  you cannot deposit a amount that is 0 or less");
            }
            else
            {
                balance += amount;
                Console.WriteLine("You have deposit: {0}", amount);
                Console.WriteLine("Your new balance: {0}", balance);
                //return balance;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error:  you cannot Withdraw an amount that is 0 or less");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Error: you cannot withdraw an amount greater than your balance");
                Console.WriteLine("Your current balance: {0}", balance);
            }
            else
            {
                balance -= amount;
                Console.WriteLine("You have withdrawn: {0}", amount);
                Console.WriteLine("Your new balance: {0}", balance);
            }
        }
    }
}