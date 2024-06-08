using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

public class Parallel_ForEach
{
    private static void DownlaodAndPrint(string url)
    {
        string content;
        using (WebClient client = new WebClient())
        {
            Thread.Sleep(1000);

            content = client.DownloadString(url);
        }

        Console.WriteLine($"url:{url}, {content.Length} characters downlaoded.");
    }

    public static void run()
    {
        List<string> Urls = new List<string>()
        {
            "https://www.facebook.com/omer.memes20",
            "https://medium.com/@omermemes83",
            "https://github.com/oms83",
        };

        Parallel.ForEach(Urls, url =>
        {
            DownlaodAndPrint(url);
        });

        Console.WriteLine("Done !");
    }
}

