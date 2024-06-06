using System;

// the Predicate delegate in C#. The Predicate delegate represents a method that takes a single
// parameter and returns a boolean value, typically used for testing conditions.

namespace Predicate_Delegate
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        public static void PredicateWithIntegers()
        {
            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(2));
        }

        public static void PredicateWithStrings()
        {
            Predicate<string> isNullOrEmpty = (string str) => string.IsNullOrWhiteSpace(str);
            Console.WriteLine(isNullOrEmpty(""));
            Console.WriteLine(isNullOrEmpty("Omer MEMES"));
        }

        public static void PredicateWithCustomClass()
        {
            Predicate<Person> isAdult = _person => _person.Age >= 18;

            Person person = new Person { Age = 24, Name = "Omer MEMES" };

            Console.WriteLine(isAdult(person));
        }
        static void Main(string[] args)
        {
            PredicateWithCustomClass();

            Console.ReadKey();
        }
    }
}
