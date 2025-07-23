// Program for printing even or odd
using System;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to print Even or Odd numbers? (E/O):");
            char choice = Convert.ToChar(Console.ReadLine().ToUpper());

            if (choice == 'E')
            {
                Console.WriteLine("Even numbers from 0 to 100:");
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (choice == 'O')
            {
                Console.WriteLine("Odd numbers from 0 to 100:");
                int j = 0;
                while (j <= 100)
                {
                    if (j % 2 != 0)
                    {
                        Console.WriteLine(j);
                    }
                    j++;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter 'E' or 'O'.");
            }
        }
    }
}
