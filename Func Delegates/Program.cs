using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Func_Delegates
{
    public class clsPerson
    {
        public string name {  get; set; }
        public int age { get; set; }

        public clsPerson(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

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

        public static void FunctionWithCustomClass()
        {
            //Func<clsPerson, string> personInfo = (clsPerson person) => $"Name: {person.name}, Age: {person.age}";

            Func<clsPerson, string> personInfo = person => $"Name: {person.name}, Age: {person.age}";

            Console.WriteLine(personInfo(new clsPerson("Omer MEMES", 24)));
            Console.WriteLine(personInfo(new clsPerson("Ali MEMES", 22)));
        }

        static void Main(string[] args)
        {
            FunctionWithCustomClass();

            Console.ReadKey();
        }
    }
}
