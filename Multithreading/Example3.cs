using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

public class Example3
{
    static Action<string> Print = Message => Console.WriteLine(Message);

    private static void DownlaodAndPrint(string url)
    {
        string content;
        using (WebClient webClient = new WebClient())
        {
            Thread.Sleep(1000);

            content = webClient.DownloadString(url);
        }

        Print($"{url}: {content.Length} characters downlaoded");
    }

    public static void run()
    {

        Thread task1 = new Thread(() => DownlaodAndPrint("https://github.com/oms83"));
        task1.Start();
        Print("Thread 1 Started...");

        Thread task2 = new Thread(() => DownlaodAndPrint("https://medium.com/@omermemes83"));
        task2.Start();
        Print("Thread 2 Started...");

        Thread task3 = new Thread(() => DownlaodAndPrint("https://www.facebook.com/omer.memes20"));
        task3.Start();
        Print("Thread 3 Started...");

        task1.Join();
        task2.Join();
        task3.Join();

        Print("\nThree Pages Are Downlaoded Successfully");

    }
}
