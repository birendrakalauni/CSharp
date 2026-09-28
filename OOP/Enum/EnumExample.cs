using System;

namespace OOP
{
    public class EnumExample
    {
        public static void Run()
        {
            OrderStatus currentStatus = OrderStatus.Pending;
            if( currentStatus == OrderStatus.Pending)
            {
                Console.WriteLine("The order is on its Way!");
            }
        }
    }

    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Canceled
    }
}