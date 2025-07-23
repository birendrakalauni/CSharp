// See https://aka.ms/new-console-template for more informat

using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int i, j;
            Console.WriteLine("Enter elements of 3x3 matrix:");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe Matrix is:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(); // for new row
            }
        }
    }
}
