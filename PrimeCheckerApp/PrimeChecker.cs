interface IPrimeChecker
{
    bool CheckPrime(int num);
    void PrintPrimeList(int s, int e);
}

class PrimeChecker : IPrimeChecker
{
    public bool CheckPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num == 2)
            return true;
        if (num % 2 == 0)
            return false;
        
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    public void PrintPrimeList(int s, int e)
    {
        Console.WriteLine($"Prime numbers between {s} and {e}:");
        for (int i = s; i <= e; i++)
        {
            if (CheckPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPrimeChecker checker = new PrimeChecker();
        
        Console.WriteLine("=== Prime Number Checker ===\n");
        
        // Test CheckPrime method
        Console.WriteLine("Testing CheckPrime method:");
        int[] testNumbers = { 2, 3, 4, 5, 10, 17, 20, 29 };
        foreach (int num in testNumbers)
        {
            Console.WriteLine($"{num} is prime: {checker.CheckPrime(num)}");
        }
        
        Console.WriteLine();
        
        // Test PrintPrimeList method
        checker.PrintPrimeList(1, 30);
        Console.WriteLine();
        checker.PrintPrimeList(50, 100);
    }
}
