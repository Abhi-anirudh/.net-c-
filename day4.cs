// Design a method to add , multiply two numbers using delegates
using System;

class SomeClass
{
    public delegate void delegate1();

    public void method1()
    {
        Console.WriteLine("Hello");
    }

    public void method2()
    {
        Console.WriteLine("Welcome");
    }

class Program
{
    public static void Main()
    {
        SomeClass obj = new SomeClass();
        delegate1 d1 = obj.method1;
        d1();
        d1=method2;
        d1();

        /*
        obj.method1();
        obj.method2();
        */
    }
}
