using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter19._9
{
    interface IPayment
    {
        void ProcessPayment(decimal amount);

        public void PrintReceipt(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} processed.");
        }
    }
    class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing Credit Card Payment...");
        }
    }
    class UpiPayment : IPayment
    {
        public  void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing UPI Payment...");
        }
    }
    public class AbstractionExample
    {
        //static void Main()
        //{
        //    IPayment payment;

        //    payment = new CreditCardPayment();
        //    payment.ProcessPayment(1000);
        //    payment.PrintReceipt(1000);

        //    payment = new UpiPayment();
        //    payment.ProcessPayment(500);
        //    payment.PrintReceipt(500);
        //}
    }
}
