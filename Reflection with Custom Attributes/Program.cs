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
    static void Main(string[] args)
    {
        Type classInfo = typeof(MyClass);
        object[] classAttributes = classInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);

        foreach (MyCustomAttribute attribute in classAttributes)
        {
            Console.WriteLine(attribute.Description);
        }

        MethodInfo methodInfo = classInfo.GetMethod("MyMethod");
        object[] methodAttributes = methodInfo.GetCustomAttributes(typeof (MyCustomAttribute), false);
        foreach (MyCustomAttribute attribute in methodAttributes)
        {
            Console.WriteLine(attribute.Description);
        }

        Console.ReadKey();
    }
}
