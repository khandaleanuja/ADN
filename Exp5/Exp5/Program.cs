using System;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Asynchronous Programming");
            Console.WriteLine("Program started...");

            // Call asynchronous method
            await PerformTaskAsync();

            Console.WriteLine("Program finished...");
            Console.ReadKey();
        }

        // Asynchronous method
        static async Task PerformTaskAsync()
        {
            Console.WriteLine("Task started...");

            // Simulating long-running task (non-blocking)
            await Task.Delay(3000); // 3 seconds delay

            Console.WriteLine("Task completed after delay.");
        }
    }
}