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

        public static void FunctionwithTwoParameter()
        {
            Func<string, string, string> getInfo = (string name, string surname) => $"Name: {name}, Surname: {surname}";
            Console.WriteLine(getInfo("Omer", "MEMES"));
            Console.WriteLine(getInfo("Ali", "MEMES"));
        }
        static void Main(string[] args)
        {
            FunctionwithTwoParameter();

            Console.ReadKey();
        }
    }
}
