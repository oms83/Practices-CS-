using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class rangeAttribute : Attribute
{
    public int Max { get; }
    public int Min { get; }
    public string ErrorMessage { get; }

    public rangeAttribute(int max, int min, string errorMessage)
    {
        Max = max;
        Min = min;
        ErrorMessage = errorMessage;
    }
}

public class Person
{
    [range(min: 18, max:60, errorMessage:"age must be between 18 and 60")]
    public int Age {  get; set; }
    public string Name { get; set; }

}

public class Example2
{
    public static void run()
    {
        Person person = new Person() { Name = "Ali MEMES", Age = 16 };
        if (Validate(person))
        {
            Console.WriteLine("person valid");
        }
        else
        {
            Console.WriteLine("Validation valid");
        }
    
    }

    public static bool Validate(Person person)
    {
        Type type = typeof(Person);

        foreach (var property in type.GetProperties())
        {
            //if (property.IsDefined(typeof(Person), false))
            if (Attribute.IsDefined(property, typeof(rangeAttribute)))
            {
                var attributeRange = (rangeAttribute)property.GetCustomAttribute(typeof(rangeAttribute));
                var value = (int)property.GetValue(person);
                if (value < attributeRange.Min || value > attributeRange.Max)
                {
                    Console.WriteLine($"Validation Failed: {property.Name} {attributeRange.ErrorMessage}");
                    return false;   
                }
            }
        }
            return true;
    }

}

