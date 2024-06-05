using System;

internal class clsDelOperations2
{
    /// <summary>
    /// This delegate indicates that the methods take two parameters, where the method returns one value from the results of the four operations
    /// </summary>
    /// <param name="a">first value</param>
    /// <param name="b">second value</param>
    /// <returns>returns operation result</returns>
    private delegate int Operation(int a, int b);

    public static void Calculate(int A, int B)
    {
        Operation sum = new Operation((int a, int b) => a + b);
        Operation sub = new Operation((int a, int b) => a - b);
        Operation mul = new Operation((int a, int b) => a * b);
        Operation div = new Operation((int a, int b) => a / b);

        Console.WriteLine($"a + b = {sum(A, B)}");
        Console.WriteLine($"a - b = {sub(A, B)}");
        Console.WriteLine($"a * b = {mul(A, B)}");
        Console.WriteLine($"a / b = {div(A, B)}");
    }

}
/*
        static void Main(string[] args)
        {
            clsDelOperations2.Calculate(100, 5);

            Console.ReadKey();
        } 
*/