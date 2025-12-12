Student student1 = new Student();
student1.name = "Alice";
student1.age = 20;
student1.contact = 1234567890;
student1.course = "Computer Science";

Student student2 = new Student();
student2.name = "Bob";
student2.age = 22;
student2.contact = 9876543210;
student2.course = "Mathematics";

student1.Details();
Console.WriteLine();
student2.Details();

class Student{
    public string name;
    public int age;
    public long contact;
    public string course;

    public void Details(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Contact: " + contact);
        Console.WriteLine("Course: " + course);
    }
}