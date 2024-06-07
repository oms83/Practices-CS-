using System;
using System.Threading;


namespace Multithreading
{
    public class Thread_Synchronization
    {
        private static int sharedCounter = 0;
        private static object sharedLock = new object();

        private static void Increment()
        {
            for (int i = 0; i < 15; i++)
            {
                lock (sharedLock)
                {
                    Console.WriteLine(sharedCounter++);
                }

                Thread.Sleep(500);
            }
        }

        public static void run()
        {
            Thread task1 = new Thread(Increment);
            task1.Start();

            Thread task2 = new Thread(Increment);
            task2.Start();

            Thread task3 = new Thread(Increment);
            task3.Start();

        }
    }
}

/*
0
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
*/

/*
    Thread Synchronization:
    Thread synchronization in C# refers to the coordination and control of the execution of multiple threads to ensure that they access 
    shared resources or perform critical sections of code in a mutually exclusive and orderly manner. Without proper synchronization,
    multiple threads operating concurrently can lead to data corruption, race conditions, and unpredictable behavior. 

    In the context of multithreading and concurrent programming, "mutually exclusive" refers to a situation where only one thread 
    at a time is allowed to execute a particular section of code or access a shared resource. The idea is to ensure that certain critical 
    operations are performed atomically, without interference from other threads.
*/