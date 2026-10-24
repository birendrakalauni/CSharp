using System;
using System.Collections.Generic;

namespace AdvancedFeatures
{
    class GenericExample
    {
        public static void Run()
        {
            // Generic Collection
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine("Numbers: ");

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            //Implement Generic method
            Display<int>(10);
            Display<string>("Hello");
            Display<double>(27.7);
            
        }
        static void Display<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}