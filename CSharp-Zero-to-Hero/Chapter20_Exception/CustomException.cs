using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter20_Exception
{
    public class MinimumBalanceException : Exception
    {
        public MinimumBalanceException(string message) : base(message)
        {
        }
    }

    public class WithdrawalLimitException : Exception
    {
        public WithdrawalLimitException(string message) : base(message)
        {
        }
    }
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            // Rule 1: Max withdrawal limit
            if (amount > 4000)
            {
                throw new WithdrawalLimitException(
                    "You cannot withdraw more than ₹4000 in a single transaction.");
            }

            // Rule 2: Minimum balance should remain ₹1000
            if (Balance - amount < 1000)
            {
                throw new MinimumBalanceException(
                    "Minimum balance of ₹1000 must be maintained.");
            }

            Balance -= amount;

            Console.WriteLine($"Withdrawal Successful: ₹{amount}");
            Console.WriteLine($"Remaining Balance: ₹{Balance}");
        }
    }
    internal class CustomException
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1500);

            try
            {
                account.Withdraw(700);
            }
            catch (WithdrawalLimitException ex)
            {
                Console.WriteLine($"Withdrawal Error: {ex.Message}");
            }
            catch (MinimumBalanceException ex)
            {
                Console.WriteLine($"Balance Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }
    }
}
