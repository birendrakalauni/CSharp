//Access the Elements of an Array

// using System;
// namespace MyProject
// {
//     class program
//     {
//         static void Main(string[] args)
//         {
//             // string[] Men = { "Niraj", "Hari", "Narey", "Birey" };
//             // Console.WriteLine(Men[3]);

//             //Change an Array Element
//             // Men[1] = "Sari";
//             // Console.WriteLine(Men[1]);
//             // //Array Length
//             // Console.WriteLine(Men.Length);
//             //Declare an Array
//             // string[] men;
//             // //// Add values, using new
//             // men = new string[] { "Niraj", "Hari", "Narey", "Birey" };
//             // Console.Write(men[0]);

//             //Loop Through an Array
//             // string[] Men = { "Niraj", "Hari", "Narey", "Birey" };
//             // for (int i = 0; i < Men.Length; i++)
//             // {
//             //     Console.WriteLine(Men[i]);
//             // }
//             // //The foreach Loop
//             // string[] cars = { "BMW", "Thar", "Mercedes", "Porsche", "Tesla" };
//             // Console.WriteLine("CAr List:");
//             // Array.Sort(cars); //sort a String
//             // foreach (string i in cars)
//             // {

//             //     Console.WriteLine(i);
//             // }

//             //Sorting Numbers
//             int[] Num = { 5, 12, 7, 9, 21, 77 };
//             Array.Sort(Num);
//             foreach (int i in Num)
//             {
//                 Console.WriteLine(i);
//             }

//         }
//     }
// }

// System.Linq Namespace :useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace.
using System;
using System.Linq;
namespace MyProject
{
    class program
    {
        static void Main(string[] args)
        {
            int[] Num = { 5, 6, 8, 9, 27, 29 };
            Console.WriteLine(Num.Max());
            Console.WriteLine(Num.Min());
            Console.WriteLine(Num.Sum());
        }
    }
}
