using System;
public class clsMulticastDel
{
    private delegate void MyDelegate(string Message);
    private static void Method1(string Message)
    {
        Console.WriteLine("Method1: " + Message);
    }

    private static void Method2(string Message)
    {
        Console.WriteLine("Method2: " + Message);
    }

    public static void CallDelegate(string Message)
    {
        MyDelegate del = new MyDelegate(Method1);
        del += Method2;
        del += (string message) => { Console.WriteLine("lambda  expression: " + message); };

        del(Message);
    }

    /*
     
        static void Main(string[] args)
        {
            clsEx1.CallDelegate("Omer Memes");

            Console.ReadKey();
        }
         
    */
}
