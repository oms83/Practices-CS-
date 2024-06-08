using System;
using System.Threading.Tasks;

public class CustomEventArgs : EventArgs
{
    public int Value1 { get; }
    public int Value2 { get; }

    public CustomEventArgs(int value1, int value2)
    {
        this.Value1 = value1;
        this.Value2 = value2;
    }
}

public class Example4
{
    public delegate void CustomEventHandler(object sender, CustomEventArgs e);
    public static CustomEventHandler CustomEvet;
    public static void HandleCustomEvent(object sender, CustomEventArgs e)
    {
        Console.WriteLine($"value1: {e.Value1}");
        Console.WriteLine($"value1: {e.Value2}");
    }
    
    public static async Task PerformAsync(CustomEventHandler customEvent)
    {
        await Task.Delay(4000);
        
        CustomEventArgs customEventArgs = new CustomEventArgs(1, 43);
     
        customEvent?.Invoke(null, customEventArgs);
    }
    public static async void run()
    {
        CustomEvet = HandleCustomEvent;

        Task task = PerformAsync(CustomEvet);
        Console.WriteLine("Task Started...");

        Console.WriteLine("\nDoing other work here..");

        await task;

        Console.WriteLine("\nDone !!");

        Console.ReadKey();
    }

}

