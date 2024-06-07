using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class MyCustomAttribute : Attribute
{
    public string Description { get; }

    public MyCustomAttribute(string description)
    {
        Description = description;
    }
}

[MyCustom("This is a class attribute")]
public class MyClass
{
    [MyCustom("This is a method attribute")]
    public void MyMethod()
    {

    }
}

internal class Program
{

    public static void run()
    {
        Type classInfo = typeof(MyClass);
        object[] classAttributes = classInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);

        foreach (MyCustomAttribute attribute in classAttributes)
        {
            Console.WriteLine(attribute.Description);
        }

        MethodInfo methodInfo = classInfo.GetMethod("MyMethod");
        object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
        foreach (MyCustomAttribute attribute in methodAttributes)
        {
            Console.WriteLine(attribute.Description);
        }
    }
    static void Main(string[] args)
    {

        Example2.run();
        Console.ReadKey();
    }
}
