Basic Keywords

1. this
	a) this keyword- reference as an object of the class in which it is used.
	b) this() - it is used for calling the constructor of class inside the another constructor of the same class.
class cons
{
    public cons():this(10)
    {
        Console.WriteLine("First Constructor");
    }
    public cons(int x)
    {
        Console.WriteLine("Second Constrtcor");
    }
}
class Test
{
    static void Main(string[]args)
    {
            cons obj=new cons();
    }
}
2. base
	i. base keyword
// See https://aka.ms/new-console-template for more information
using Test2;
class parent
{
    public int x, y;
    public void set()
    {
        x = 10;
        y = 20;
    }
}
class child:parent
{
    int x, y;
    public void get()
    {
        this.x = base.x;
        this.y=base.y;
    }
    public void put()
    {
        Console.WriteLine("x=" + x);
        Console.WriteLine("y=" + y);
    }
}

class Test
{
    static void Main(string[]args)
    {
        child obj=new child();
        obj.set();
        obj.get();
        obj.put();
    }
}
	ii. base() method- it is used for calling the base class constructor in the derived class constructor.

class parent
{
    public parent()
    {
        Console.WriteLine("First Constrtor of Parent Class");
    }
    public parent(int n)
    {
        Console.WriteLine("Second Constructor of Parent Class");
    }
 
}
class child:parent
{
    public child() : base(10)
    {
        Console.WriteLine("Constrctor of Child class");
    }


}

class Test
{
    static void Main(string[]args)
    {
        child obj=new child();
    }
}

3. static
	i. static variable
	ii. static method
	iii. static class

// See https://aka.ms/new-console-template for more information
using Test2;
class dhananjay
{
    public static class dksasfather
    {
        public static void father()
        {
            System.Console.WriteLine("I Love my kids");
        }

    }
    public static class dksasteacher
    {
        public static void teacher()
        {
            System.Console.WriteLine("I try my level best");
        }

    }
}
class Test
{
    static void Main(string[]args)
    {
        dhananjay.dksasfather.father();
        dhananjay.dksasteacher.teacher();

    }
}

4. sealed
	i. sealed class - we can not inherit a sealed class
	ii. sealed method- we can not override a sealed method

Method overriding
class parent
{
    public virtual void thinking()
    {
        Console.WriteLine("Parent Thinking is old school");
    }
}
class child:parent
{
    public override void thinking()
    {
        Console.WriteLine("We are in modern era");
    }
}
class Test
{
    static void Main(string[]args)
    {
        parent pobj;
        pobj=new child();
        pobj.thinking();

    }
}

interface- specifies the responsibility of a class.
		100% abstract


 and abstract class

interface punitwork
{
	bool checkprime(int num);
	void printprimelist(int s,int e);
}

class punit : punitwork
{
	public bool checkprime(int num)
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
	
	public void printprimelist(int s, int e)
	{
		Console.WriteLine($"Prime numbers between {s} and {e}:");
		for (int i = s; i <= e; i++)
		{
			if (checkprime(i))
			{
				Console.Write(i + " ");
			}
		}
		Console.WriteLine();
	}
}