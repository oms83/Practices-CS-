using System;
using System.Collections.Generic;
using System.Threading;

namespace Multithreading
{
    public class RaceCondation
    {
        private static int sharedCounter = 0;

        private static void Increment()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(sharedCounter++);
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
2
1
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
14
13
15
17
16
18
19
19
20
21
22
23
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
*/

/*
    What is Race Condition?

    A race condition is a situation in concurrent programming where the behavior of a program depends on the relative timing of events, 
    such as the order in which threads are scheduled to run.

    In other words, a race condition occurs when the correctness of a program's execution depends on the unpredictable interleaving of 
    operations from multiple threads.

    Race conditions can lead to unexpected and undesirable outcomes, including:
    Data corruption,
    Application crashes
    or other forms of incorrect behavior.

    They are particularly common in multithreaded or parallel programming, where multiple threads execute concurrently and may 
    access shared resources or variables. 
*/