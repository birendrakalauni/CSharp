//Runtime Polymorphism and Code Extensibility

using System;
namespace OOP
{
    class RuntimePolymorphism
    {
        public static void Run()
        {
            Payment p;
            p = new CashPayment();
            p.Pay();

            p = new CardPayment();
            p.Pay();
        }
    }

    abstract class Payment
    {
        public abstract void Pay();
    }

    class CashPayment : Payment
    {
        public override void Pay()
        {
           Console.WriteLine("Cash Payment");
        }
    }

    class CardPayment : Payment
    {
        public override void Pay()
        {

            Console.WriteLine("Card Payment");
        }
    }
}