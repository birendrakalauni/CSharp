using System;

using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class SimpleAsyncExample
    {
        static async Task DownloadData()
        {
            Console.WriteLine("Starting...");

            await Task.Delay(2000);

            Console.WriteLine("Completed!");
        }
        public static async Task Run()
        {
            await DownloadData();
        }
    }
}