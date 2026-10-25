using System;
namespace AdvancedFeatures
{
    class ThrowExample
    {
        public static void Run()
        {
            try
            {
                int age = -5;

                if(age < 0)
                {
                    throw new ArgumentException("Age can't be negative.");
                }
                Console.WriteLine($"Age: {age}");
            } catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}