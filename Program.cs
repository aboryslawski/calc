// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine(Calc.Add(1, 3));

public class Calc
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Substract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}