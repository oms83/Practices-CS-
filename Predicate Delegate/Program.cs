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
        static void Main(string[] args)
        {
            PredicateWithIntegers();

            Console.ReadKey();
        }
    }
}
