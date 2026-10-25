using System;
namespace AdvancedFeatures
{
    class FinallyExample
    {
        public static void Run()
        {
            try
            {
                int balance = 1000;
                int withdrawal = 1500;

                if(withdrawal > balance)
                {
                    throw new Exception("Insufficient balance.");
                }
                Console.WriteLine("Withdrawal successful.");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Transaction process completed.");
            }
        }
    }
}