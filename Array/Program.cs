//Access the Elements of an Array
using System;
namespace MyProject
{
    class program
    {
        static void Main(string[] args)
        {
            // string[] Men = { "Niraj", "Hari", "Narey", "Birey" };
            // Console.WriteLine(Men[3]);

            //Change an Array Element
            // Men[1] = "Sari";
            // Console.WriteLine(Men[1]);
            // //Array Length
            // Console.WriteLine(Men.Length);
            //Declare an Array
            // string[] men;
            // //// Add values, using new
            // men = new string[] { "Niraj", "Hari", "Narey", "Birey" };
            // Console.Write(men[0]);

            //Loop Through an Array
            string[] Men = { "Niraj", "Hari", "Narey", "Birey" };
            for (int i = 0; i < Men.Length; i++)
            {
                Console.WriteLine(Men[i]);
            }
            //The foreach Loop
            string[] cars = { "BMW", "Thar", "Mercedes", "Porsche", "Tesla" };
            Console.WriteLine("CAr List:");
            foreach (string i in cars)
            {

                Console.WriteLine(i);
            }

        }
    }
}
//Change an Array Element
