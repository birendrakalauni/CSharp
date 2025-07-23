// C# Jagged Arrays
using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Declare a jagged array with 3 sub-arrays
            // int[][] jarray = new int[3][];

            // // Initialize sub-arrays
            // jarray[0] = new int[] { 1, 2, 3 };
            // jarray[1] = new int[] { 4, 5 };
            // jarray[2] = new int[] { 6 };

            // // Print the contents of the first sub-array
            // Console.WriteLine(string.Join(", ", jarray[0]));
            int[][] jarray = new int[3][];
            jarray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jarray[1] = new int[3] { 10, 20, 30 };
            jarray[2] = new int[] { 12, 50, 60, 70, 32 };
            Console.WriteLine("The first element of first row:" + jarray[0][0]);
        }
    }
}
