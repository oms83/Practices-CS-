using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegates
{
    internal class Program
    {
        public static void FunctionwithNoParameters()
        {
            Func<string> getGreeting = () => "Hello, world";
            Console.WriteLine(getGreeting());
        }

        public static void FunctionwithOneParameter()
        {
            Func<int, int> clac = x => x * x ;
            Console.WriteLine(clac(5));
            Console.WriteLine(clac(7));

        }
        static void Main(string[] args)
        {
            FunctionwithOneParameter();

            Console.ReadKey();
        }
    }
}
