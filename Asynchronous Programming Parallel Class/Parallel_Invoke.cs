using System;
using System.Threading.Tasks;

// Parallel.Invoke allows you to execute multiple actions in parallel.
public class Parallel_Invoke
{
    public static void run()
    {
        // Run the functions in parallel
        Console.WriteLine("Starting parallel functions.");
        Parallel.Invoke(Function1, Function2, Function3);
        Console.WriteLine("All parallel functions are completed.");
    }
    static void Function1()
    {
        Console.WriteLine("Function 1 is starting.");
        Task.Delay(1000).Wait(); // Simulating work
        Console.WriteLine("Function 1 is completed.");
    }


    static void Function2()
    {
        Console.WriteLine("Function 2 is starting.");
        Task.Delay(1000).Wait(); // Simulating work
        Console.WriteLine("Function 2 is completed.");
    }


    static void Function3()
    {
        Console.WriteLine("Function 3 is starting.");
        Task.Delay(1000).Wait(); // Simulating work
        Console.WriteLine("Function 3 is completed.");
    }
}

