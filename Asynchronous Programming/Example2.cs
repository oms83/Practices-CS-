using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public class Example2
{
    private static async Task<int> FetchDataAsync()
    {
        await Task.Delay(4000);

        return 43;
    }

    public static async Task run()
    {
        Task<int> resultTask = FetchDataAsync();

        Console.WriteLine("Doing some things here...");

        int result = await resultTask;

        Console.WriteLine("Result: " + result);
    }
}
