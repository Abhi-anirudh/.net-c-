class Line
{
    int i;
    public Line()
    {
        for(i=1;i<=70;i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    public Line(char ch)
    {
        for(i=1;i<=70;i++)
        {
            Console.Write(ch); 
        }
        Console.WriteLine();
    }
}
class Test
{
    String name;
    int age;
    public Test(String name,int age) {
        this.name = name;
        this.age = age;
    }
    public void show()
    {
        Console.WriteLine("Name="+name);
        Console.WriteLine("Age=" + age);
    }
}
class Logic
{
    static void Main(string[] args)
    {
        Test obj1=new Test("Manoj",23);
        Line lobj;
        lobj=new Line();
        obj1.show();
        lobj=new Line();
        Test obj2=new Test("Devansh",25);
        obj2.show();
        lobj=new Line('&');
    }
}