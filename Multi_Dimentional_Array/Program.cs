// See https://aka.ms/new-console-template for more informat

// using System;

// namespace matrix
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // int[,] array = new int[3, 3];
//             // int i, j;
//             // Console.WriteLine("Enter elements of 3x3 matrix:");

//             // for (i = 0; i < 3; i++)
//             // {
//             //     for (j = 0; j < 3; j++)
//             //     {
//             //         Console.Write($"Element [{i},{j}]: ");
//             //         array[i, j] = Convert.ToInt32(Console.ReadLine());
//             //     }
//             // }

//             // Console.WriteLine("\nThe Matrix is:");
//             // for (i = 0; i < 3; i++)
//             // {
//             //     for (j = 0; j < 3; j++)
//             //     {
//             //         Console.Write(array[i, j] + "\t");
//             //     }
//             //     Console.WriteLine(); // for new row
//             // }

//             //Access Elements of a 2D Array
//             int[,] Num = { { 9, 8, 5 }, { 4, 7, 3 } };
//             Console.WriteLine(Num[2, 2]);
//         }
//     }
// }

using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Num = { { 9, 8, 5 }, { 4, 7, 3 } };
            Console.WriteLine(Num[1, 2]);

            //Change Elements of a 2D Array
            Console.WriteLine("Value Change:");
            Num[0, 0] = 1;//Change value to 5
            Console.WriteLine(Num[0, 0]);

            //Loop Through a 2D Array
            Console.WriteLine("Using Loop:");
            Console.WriteLine("Using foreach loop:");
            foreach (int i in Num)//foreach loop
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Using for loop:");
            for (int i = 0; i < Num.GetLength(0); i++)
            {
                for (int j = 0; j < Num.GetLength(1); j++)
                {
                    Console.WriteLine(Num[i, j]);
                }
            }
        }
    }
}