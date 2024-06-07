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

    public struct stPersonInfo
    {
        public string FullName;
        public int? Age;
        public DateTime? DateOfBirth;
    }

    public static void Example4()
    {
        stPersonInfo personInfo = new stPersonInfo();
        personInfo.FullName = "Omer MEMES";
        personInfo.DateOfBirth = Convert.ToDateTime("03-08-2000");

        Console.WriteLine($"Name: {personInfo.FullName}");
        int age = personInfo.Age ?? 18;
        Console.WriteLine($"Name: {age}");
        Console.WriteLine($"Name: {personInfo.DateOfBirth}");
    } 
    public static void Example5()
    {
        stPersonInfo personInfo = new stPersonInfo();
        personInfo.FullName = "Omer MEMES";
        personInfo.DateOfBirth = Convert.ToDateTime("03-08-2000");

        Console.WriteLine($"Name: {personInfo.FullName}");
        Console.WriteLine($"Name: {personInfo.Age ?? 18}");
        Console.WriteLine($"Name: {personInfo.DateOfBirth}");
    }

    public static void Example6(string Name, Nullable<int>Age)
    {
        Console.WriteLine($"Name: {Name}");

        if (Age.HasValue) 
            Console.WriteLine($"Age: {Age}");
        else
            Console.WriteLine("Age is null");
    }
    static void Main(string[] args)
    {
        Example6("Omer MEMES", null);
        Example6("Omer MEMES", 24);

        Console.ReadKey();
    }
}

