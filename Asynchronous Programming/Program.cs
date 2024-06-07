using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Example2.run();
            Console.ReadKey();
        }
    }
}
