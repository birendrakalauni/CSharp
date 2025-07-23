using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers from 0 to 100:");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Odd numbers from 0 to 100:");
            int j = 0; // Initialize j
            while (j <= 100)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
        }
    }
}
