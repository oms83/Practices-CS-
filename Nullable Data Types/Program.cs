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

    static void Main(string[] args)
    {
        Example1();

        Console.ReadKey();
    }
}

