using System;
using System.Runtime.InteropServices;
using System.Security.Policy;

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
        static void Main(string[] args)
        {
            ActionDelegateWithTwoParameters();

            Console.ReadKey();
        }
    }
}
