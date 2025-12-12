class DigitCounter
{
    private int number;
    public DigitCounter(int num)
    {
        number = num;
    }
    public int CountDigits()
    {
        int count = 0;
        int temp = Math.Abs(number);   
        if (temp == 0)
            return 1;
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }
        return count;
    }
    public void Display()
    {
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Number of Digits: " + CountDigits());
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        DigitCounter dc1 = new DigitCounter(Console.ReadLine(););
        dc1.Display();

        Console.WriteLine();

        DigitCounter dc2 = new DigitCounter(9876);
        dc2.Display();

        Console.WriteLine();

        DigitCounter dc3 = new DigitCounter(0);
        dc3.Display();

        Console.WriteLine();

        DigitCounter dc4 = new DigitCounter(-54321);
        dc4.Display();
    }
}
