using System;
using System.Threading.Tasks;

public class CustomEventArgs3 : EventArgs
{
    public int Value1 { get; }
    public int Value2 { get; }

    public CustomEventArgs3(int value1, int value2)
    {
        this.Value1 = value1;
        this.Value2 = value2;
    }
}
public class Example6
{
    public delegate void CallBackEventHandler(object sender, CustomEventArgs3 e);
    public static event CallBackEventHandler CallBack;
    public static void HandleCallBackEventHandler(object sender, CustomEventArgs3 e)
    {
        Console.WriteLine($"value1: {e.Value1}");
        Console.WriteLine($"value1: {e.Value2}");
    }
    public static async Task PerformAsync(CallBackEventHandler CallBack)
    {
        await Task.Delay(4000);

        CustomEventArgs3 customEventArgs = new CustomEventArgs3(1, 43);

        CallBack?.Invoke(null, customEventArgs);
    }
    public static async void run()
    {
        CallBack = HandleCallBackEventHandler;

        Task task = PerformAsync(CallBack);
        Console.WriteLine("Task Started...");

        Console.WriteLine("\nDoing other work here..");

        await task;

        Console.WriteLine("\nDone !!");

        Console.ReadKey();
    }
}

