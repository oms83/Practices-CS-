using System;
using System.Threading.Tasks;

internal class Parallel_for
{
    public static void run()
    {
        int numberOfIterations = 10;

        Parallel.For(0, numberOfIterations, i => {
            Console.WriteLine($"Execution iteration {i} on thread {Task.CurrentId}");
            Task.Delay(1000).Wait();
        });

        Console.WriteLine("All iterations completed.");

        Parallel.For(0, numberOfIterations, ProcessIteration);
        Console.WriteLine("All iterations completed.");
    }

    public static void ProcessIteration(int i)
    {
        Console.WriteLine($"Execution iteration {i} on thread {Task.CurrentId}");
        Task.Delay(1000).Wait();
    }
}
