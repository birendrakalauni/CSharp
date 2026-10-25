using System;

namespace AdvancedFeatures
{
    class TryCatchExample
    {
        public static void Run()
        {
            try
            {
                int a =10;
                int b =0;
                int result = a/b;

                Console.WriteLine($"Result: {result}");
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero.");
            }
        }
    }
}
// The try block contains code that might cause an exception. The catch block handles a matching exception.