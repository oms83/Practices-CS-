using System;
using System.Security.Permissions;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class RangeAttribute : Attribute
{
    public int Max { get; }
    public int Min { get; }

    public string ErrorMessage { get; }

    public RangeAttribute(int max, int min, string errorMessage)
    {
        Max = max;
        Min = min;
        ErrorMessage = errorMessage;
    }
}

public class People
{
    [Range(60, 18, errorMessage : "Age must be between 18 and 60")]
    public int Age { get; set; }

    [Range(15, 5, errorMessage : "Experience must be between 5 and 15")]
    public int Experience { get; set; }
    public string Name { get; set; }
}

internal class Custom_Attribute_With_Validation
{
    public static void run()
    {
        People person = new People { Age = 14, Name = "Ali MEMES", Experience=10 };

        if (Validate(person))
        {
            Console.WriteLine("Person is valid");
        }
        else
        {
            Console.WriteLine("Validation failed");
        }
    }

    public static bool Validate(People person)
    {
        Type type = typeof(People);

        foreach (var property in type.GetProperties())
        {
            if (property.IsDefined(typeof(RangeAttribute), false)) 
            {
                var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
                var value = (int)property.GetValue(person);

                if (value > rangeAttribute.Max || value < rangeAttribute.Min)
                {
                    Console.WriteLine($"Validation failed for property {property.Name} {rangeAttribute.ErrorMessage}");
                }
            }
        }
        return true;
    }


}
