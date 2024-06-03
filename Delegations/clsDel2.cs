using System;

public class clsDel2
{
    delegate void myDelegate(string Message);
    
    private static void _PrintMessage(string Message) => Console.WriteLine(Message);

    public static void PrintMessageByDel(string Message)
    {
        myDelegate del = new myDelegate(_PrintMessage);

        del(Message);
    }

    /*
     static void Main(string[] args)
     {
         clsDel2.PrintMessageByDel("Hello World!");
     
         Console.ReadKey();
     
     }
    */
}
