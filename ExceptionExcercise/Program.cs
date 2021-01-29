using System;
using System.Globalization;
using ExceptionExcercise.Entities;
using ExceptionExcercise.Entities.Exceptions;

namespace ExceptionExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter the amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
