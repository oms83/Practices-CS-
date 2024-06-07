using System;
using System.Windows.Forms;
namespace Event_Args_And_Delegates_And_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caller.run();
            Console.ReadKey();
        }
    }
}

/*
                   -- Used to run form --

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 

*/