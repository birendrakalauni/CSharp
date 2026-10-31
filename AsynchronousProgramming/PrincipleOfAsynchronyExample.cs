using System;

using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class PrincipleOfAsynchronyExample
    {
        public static async Task Run()
        {
            Console.WriteLine("Program Started.");

            Task task = PerformAsyncOperation();

            Console.WriteLine("Doing other work...");
            await task;

            Console.WriteLine("Program Completed!");
        }

        static async Task PerformAsyncOperation()
        {
            Console.WriteLine("Operation Started.");

            await Task.Delay(2000);

            Console.WriteLine("Operation completed.");
        }
    }

}