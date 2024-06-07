using System;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;

internal class Example3
{
    private static async Task DownlaodAndPrint(string url)
    {
        string content;
        using (WebClient client = new WebClient())
        {
            await Task.Delay(3000);

            content = client.DownloadString(url);
        }

        Console.WriteLine($"url:{url}, {content.Length} characters downlaoded.");
    }

    public static async void run()
    {
        Task task1 = DownlaodAndPrint("https://www.facebook.com/omer.memes20");
        Console.WriteLine("Task 1 Started...");

        Task task2 = DownlaodAndPrint("https://medium.com/@omermemes83");
        Console.WriteLine("Task 2 Started...");

        Task task3 = DownlaodAndPrint("https://github.com/oms83");
        Console.WriteLine("Task 3 Started...");

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("\nAll tasks finished execution.");

        Console.ReadKey();
    }
}

