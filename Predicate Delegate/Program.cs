using System;

// the Predicate delegate in C#. The Predicate delegate represents a method that takes a single
// parameter and returns a boolean value, typically used for testing conditions.

namespace Predicate_Delegate
{
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
        static void Main(string[] args)
        {
            PredicateWithStrings();

            Console.ReadKey();
        }
    }
}
