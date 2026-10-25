using System;

namespace AdvancedFeatures
{
    class ExceptionExample
    {
        public static void Run()
        {
            try
            {
                int[] numbers = {10, 20, 30};
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Array index is out of range");
            }
        }
    }
}