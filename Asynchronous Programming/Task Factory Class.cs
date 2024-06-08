using System;
using System.Threading.Tasks;
using System.Threading;

public class Task_Factory_Class
{
    public static void run()
    {
        // Define a cancellation token so we can stop the task if needed
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;


        // Create a TaskFactory with some common configuration
        TaskFactory taskFactory = new TaskFactory(
            token,
            TaskCreationOptions.AttachedToParent,
            TaskContinuationOptions.ExecuteSynchronously,
            TaskScheduler.Default);


        // Use the TaskFactory to create and start a new task
        Task task1 = taskFactory.StartNew(() =>
        {
            Console.WriteLine("Task 1 is running");
            // Simulate some work
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 completed");
        });


        // Create another task using the same TaskFactory
        Task task2 = taskFactory.StartNew(() =>
        {
            Console.WriteLine("Task 2 is running");
            // Simulate some work
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 completed");
        });


        try
        {
            // Wait for both tasks to complete
            Task.WaitAll(task1, task2);
            Console.WriteLine("All tasks completed.");
        }
        catch (AggregateException ae)
        {
            // Handle exceptions if any task throws
            foreach (var e in ae.InnerExceptions)
                Console.WriteLine($"Exception: {e.Message}");
        }


        // Dispose of the CancellationTokenSource
        cts.Dispose();
    }
}

