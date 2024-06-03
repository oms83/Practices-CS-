using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsSimpleDelegate.SubscribeToDelegates();
            clsSimpleDelegate.CallFunctions1();
            clsSimpleDelegate.UnsubscribeToDelegates();
            clsSimpleDelegate.CallFunction2();

            Console.ReadKey();

        }
    }
}
