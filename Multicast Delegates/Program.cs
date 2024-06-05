using Multicast_Delegates.Data_Back;
using System;
using System.Windows.Forms;

namespace Multicast_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SenderWithMulipleObjects.Start();

            Console.ReadKey();
        }
    }
}
