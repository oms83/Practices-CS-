using System;
using System.Collections.Generic;
using System.Linq;


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

        public static void PredicateWithNullableTypes()
        {
            Predicate<int?> hasValue = x => x.HasValue;
            Console.WriteLine(hasValue(4));
            Console.WriteLine(hasValue(null));
        }

        public static void PredicateWithArray()
        {
            int[] arr = { 1, 2, 3, 43, 542, 12, 12, -12, -43, 53, -21 };
            Predicate<int> isLessThanThree = x => x < 3;
            int[] arrLessThanThree = Array.FindAll(arr, n => isLessThanThree(n)).ToArray();
            Console.WriteLine(string.Join(",", arrLessThanThree));
        }
        static void Main(string[] args)
        {
            PredicateWithArray();

            Console.ReadKey();
        }
    }
}
