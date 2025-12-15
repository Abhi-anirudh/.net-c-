using System;

delegate int Calculator(int x, int y);

class Task
{
    public int add(int x, int y)
    {
        return x + y;
    }

    public int diff(int x, int y)
    {
        return x - y;
    }

    public int product(int x, int y)
    {
        return x * y;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Task obj = new Task();

        Console.Write("Enter first integer: ");
        int a = ReadInt();
        Console.Write("Enter second integer: ");
        int b = ReadInt();

        Calculator calculate = obj.add;
        Console.WriteLine(calculate(a, b));

        calculate = obj.diff;
        Console.WriteLine(calculate(a, b));

        calculate = obj.product;
        Console.WriteLine(calculate(a, b));
    }

    private static int ReadInt()
    {
        while (true)
        {
            string? s = Console.ReadLine();
            if (int.TryParse(s, out int val)) return val;
            Console.Write("Invalid input. Please enter an integer: ");
        }
    }
}
