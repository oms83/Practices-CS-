using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading;

/*
    An Action delegate in C# is a predefined delegate type provided by the .NET Framework that 
    represents a method that performs an action but does not return a value. It can encapsulate 
    a method that takes zero or more parameters but always has a void return type. There are 
    different variations of the Action delegate, which can take up to 16 parameters. 
*/

namespace Action_Delegate
{
    internal class Program
    {
        public static void BasicActionDelegate()
        {
            Action greet = () => Console.WriteLine("Hello World!");
            greet();
        }

        public static void ActionDelegateWithOneParameter()
        {
            Action<string> greet = name => Console.WriteLine($"Hello, {name}");
            greet("Omer MEMES");
        }

        public static void ActionDelegateWithTwoParameters()
        {
            Action<int, int> sum = (a, b) => Console.WriteLine(a+b);
            sum(10, 25);
        }
        public static void ActionDelegateWithThreeParameters()
        {
            Action<string, short, bool> employeeInfo = (name, age, isActive) => Console.WriteLine($"Name: {name}, Age: {age}, isActive: {isActive}");
            employeeInfo("Omer MEMES", 23, true);
        }
        public static void UsingActionDelegateToModifyList()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            Action<List<int>> doubleNumbers = nums =>
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    numbers[i] *= 2;
                }
            };
            doubleNumbers(numbers);
            numbers.ForEach(number=>Console.WriteLine(number));
        }

        public static void ActionDelegateForLogging()
        {
            // log to console
            Action<string> logMessage = message => Console.WriteLine(message);
            logMessage("This is a log entry.");
        }
        public static void ActionDelegateWithAnonymousMethod()
        {
            Action<string> print = delegate (string message)
            {
                Console.WriteLine(message);
            };

            print("hello world!");
        }

        static void Main(string[] args)
        {
            ActionDelegateForLogging();

            Console.ReadKey();
        }
    }
}
