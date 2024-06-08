using System;
using static Example4;
using System.Threading.Tasks;

public class CustomEventArgs2 : EventArgs
{
    public int Value1 { get; }
    public int Value2 { get; }

    public CustomEventArgs2(int value1, int value2)
    {
        this.Value1 = value1;
        this.Value2 = value2;
    }
}
public class Example5
{
    public static EventHandler<CustomEventArgs2> CallBackEventHandler;

    public static void HandleCallBackEventHandler(object sender, CustomEventArgs2 e)
    {
        Console.WriteLine($"value1: {e.Value1}");
        Console.WriteLine($"value1: {e.Value2}");
    }
    public static async Task PerformAsync()
    {
        await Task.Delay(4000);

        CustomEventArgs2 customEventArgs = new CustomEventArgs2(1, 43);

        CallBackEventHandler?.Invoke(null, customEventArgs);
    }

    public static async void run()
    {
        CallBackEventHandler = HandleCallBackEventHandler;

        Task task = PerformAsync();
        Console.WriteLine("Task Started...");

        Console.WriteLine("\nDoing other work here..");

        await task;

        Console.WriteLine("\nDone !!");

        Console.ReadKey();
    }
}
