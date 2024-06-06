using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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

        public static void UsingPredicateInAList()
        {
            List<int> numbers = new List<int>() { 2, 2, -12, -213, 32, 3, 54, 75, 53, 31, 75, 12 };
            
            Predicate<int> isGreaterThanThree = x => x > 3;
            List<int> numbersGreaterThanThree = numbers.FindAll(n => isGreaterThanThree(n));

            numbersGreaterThanThree.ForEach(n => Console.WriteLine(n));

        }

        public static void CombiningPredicates()
        {
            Predicate<int> isOdd = x => x % 2 != 0;
            Predicate<int> isPositive = x => x >= 0;

            Predicate<int> isPositiveAndOdd = x => isOdd(x) && isPositive(x);

            Console.WriteLine(isPositiveAndOdd(5));
            Console.WriteLine(isPositiveAndOdd(53));
            Console.WriteLine(isPositiveAndOdd(52));

        }

        static void Main(string[] args)
        {
            CombiningPredicates();

            Console.ReadKey();
        }
    }
}
