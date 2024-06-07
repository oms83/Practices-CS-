using System;
using System.Threading;
using System.Threading.Tasks;

public class Example2
{
    private static void Method1(string ThreadName)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{ThreadName} Method1: {i}");
            Thread.Sleep(500);
        }
    }
    private static void Method2(string ThreadName)
    {
        for (int i = 10; i < 20; i++)
        {
            Console.WriteLine($"{ThreadName} Method2: {i}");
            Thread.Sleep(500);
        }
    }

    public static void run()
    {

        Thread task1 = new Thread(() => Method1("Thread1 "));
        Thread task2 = new Thread(() => Method2("Thread2 "));

        Console.WriteLine("\nTask1 and Task2 Started\n");

        task1.Start();
        task2.Start();

        //Wait for tasks to finish
        task1.Join();
        task2.Join();

        Console.WriteLine("\nTask1 and Task2 Done\n");
    }
}

