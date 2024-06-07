using System;

internal class Program
{
    public static void Example1()
    {
        Nullable<int> age = new Nullable<int>();
        Console.WriteLine(age); // null
        age = 23;
        Console.WriteLine(age);

    }
    public static void Example2()
    {
        int? Age = 23;
        Console.WriteLine(Age);

        DateTime? DateOfBirth = null;
        Console.WriteLine(DateOfBirth);

        // Resolve warnings related to language features and versions
        //string? Name = null;
        //Console.WriteLine(Name);
    }
    public static void Example3()
    {
        int? Value = null;

        if (Value.HasValue)
        {
            Console.WriteLine(Value);
        }
        else
        {
            Console.WriteLine("Value is null");
        }

    }
    static void Main(string[] args)
    {
        Example3();

        Console.ReadKey();
    }
}

