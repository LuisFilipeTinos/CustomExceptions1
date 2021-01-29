using System;
using System.Collections.Generic;
using System.Text;
using ExceptionExcercise.Entities.Exceptions;

namespace ExceptionExcercise.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Error! The amount of money is higher than the withdraw limit!");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Error! You don´t have suficient money to withdraw!");
            }

            Balance = Balance - amount;
        }

    }
}
