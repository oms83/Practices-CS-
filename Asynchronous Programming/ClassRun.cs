using System;
using System.Threading;
using System.Threading.Tasks;


namespace Asynchronous_Programming
{
    internal class ClassRun
    {
        public static void DownlaodFile(string FileName)
        {
            Console.WriteLine($"\n{FileName}: Started...");
            Thread.Sleep(3000);
            Console.WriteLine($"\n{FileName}: Complated...");
        }
        public static async void run()
        {
            Task task1 = Task.Run(() => DownlaodFile("File 1"));

            Task task2 = Task.Run(() => DownlaodFile("File 2"));

            await Task.WhenAll(task1, task2);

            Console.WriteLine("\nFiles have been downloaded");
        }
    }
}
