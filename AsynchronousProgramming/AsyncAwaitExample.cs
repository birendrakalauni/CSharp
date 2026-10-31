using System;

using 
 System.Threading.Tasks;

 namespace AsynchronousProgramming
{
    class AsyncAwaitExample
    {

        static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Data received successfully.";
        }
        public static async Task Run()
        {
            Console.WriteLine("Fetching Data...");
            string result = await GetDataAsync();

            Console.WriteLine(result);
            Console.WriteLine("Program finished.");
        }
    }
}

// Note: Use Task<T> when an asynchronous method needs to return a value. Here, Task<string> returns a string.