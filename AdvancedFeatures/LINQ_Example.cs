using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedFeatures
{
    class LINQExample
    {
        public static void Run()
        {
            List<int> numbers = new List<int>
            {
                10,30, 20,25, 15, 37
            };

            var result = numbers.Where(n => n >20); //n => n > 20 is a lambda expression that checks whether each number is greater than 20.
            
            var doubled = numbers.Select(n => n*2);

            var ascending = numbers.OrderBy(n => n);
            
            int first = numbers.First();

            int sum = numbers.Sum();
            
            Console.WriteLine("Filter numbers greater than 20");
            foreach(var number in result)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Select: transform each number");

            foreach(var doubleNum in doubled)
            {
                Console.WriteLine(doubleNum);

            }

             Console.WriteLine();
            Console.WriteLine("OrderBy: sort in ascending order");
             
            foreach(var ascendingOrder in ascending)
            {
                Console.WriteLine(ascendingOrder);
            }

             Console.WriteLine();
            Console.WriteLine("First: get the first element");
            Console.WriteLine(first);

            Console.WriteLine();
            Console.WriteLine("Sum: calculate the total");
            Console.WriteLine(sum);
        }
    }
}