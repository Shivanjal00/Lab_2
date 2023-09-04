using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seal_2
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }
    }

    public sealed class SavingsAccount : BankAccount
    {
        private decimal InterestRate { get; }

        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Interest calculated and added. New balance: ${Balance}");
        }

        public override void Withdraw(decimal amount)
        {
            // Override the Withdraw method to prevent withdrawals from a savings account.
            Console.WriteLine("Withdrawals are not allowed from a savings account.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a savings account with an initial balance and interest rate
            SavingsAccount savingsAccount = new SavingsAccount("SAV123", 1000.0m, 0.05m);

            Console.WriteLine($"Account Number: {savingsAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${savingsAccount.Balance}");

            savingsAccount.Deposit(500.0m);
            savingsAccount.CalculateInterest();

            // Attempt to withdraw from the savings account (this should not work)
            savingsAccount.Withdraw(200.0m);

            Console.WriteLine($"Final Balance: ${savingsAccount.Balance}");
        }
    }
}
