
using System;


public class clsSimpleDelegate
{
    private delegate void CallFunction();
    static CallFunction Caller;
    private static void _Print()
    {
        Console.WriteLine("hello world!");
    }

    private static void _Print2()
    {
        Console.WriteLine("this is a print2 fuction");
    }
    public static void SubscribeToDelegates()
    {
        Caller += _Print;
        Caller += _Print2;
        Caller += () => { Console.WriteLine("this is an anonymous function"); };
    }
    public static void UnsubscribeToDelegates()
    {
        Caller -= _Print;
        Caller -= _Print2;
        Caller -= () => { Console.WriteLine("this is an anonymous function"); };
    }
    public static void CallFunctions1()
    {
        Console.WriteLine("\nCalled Functions");
        Caller?.Invoke();
    }

    public static void CallFunction2()
    {
        Console.WriteLine("\nCalled Functions");
        if (Caller != null)
        {
            Caller();
        }

        /*
         Called Functions
         hello world!
         this is a print2 fuction
         this is an anonymous function
         
         Called Functions
         this is an anonymous function
        */
    }
}
