using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace DesignByContract_assignment
{
    public class Account
    {
        private double balance;
        public double Balance { get; }

        public Account(double balance)
        {
            this.balance = balance;
        }

        public double Deposit(double amount)
        {
            Contract.Requires(amount > 0,"The amount you want to deposit is 0 or less");

           
            balance += amount;

            Console.WriteLine("your new balance: {0}", balance);
            return balance;
           
        }

        public double Withdraw(double amount)
        {
            Contract.Requires(amount > 0, "the amount is 0 or less");
            Contract.Requires(amount < Balance, "the amount exceed you balance");


            balance -= amount;

            Console.WriteLine("your new balance: {0}",balance);
            return balance;
        }
    }
}