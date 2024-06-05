using System;
using System.Windows.Forms;

namespace Multicast_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            Console.ReadKey();
        }
    }
}
