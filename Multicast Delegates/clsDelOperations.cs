using System;


internal class clsDelOperations
{
    private delegate int Operation(int a, int b);
    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static int Mul(int a, int b)
    {
        return a * b;
    }

    private static int Div(int a, int b) => a / b;

    private static int Sub(int a, int b) => a - b;

    public static void Clac()
    {
        Operation sum = new Operation(Add);
        Operation sub = new Operation(Sub);
        Operation mul = new Operation(Mul);
        Operation div = new Operation(Div);
        

        Console.WriteLine($"a + b = {sum(100, 5)}");
        Console.WriteLine($"a - b = {sub(100, 5)}");
        Console.WriteLine($"a * b = {mul(100, 5)}");
        Console.WriteLine($"a / b = {div(100, 5)}");
    }

}
