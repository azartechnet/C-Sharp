using System;
using System.Security.Cryptography.X509Certificates;

public class Employee
{
    public int empid;
    public String empname;
    public int age;

    void get1()
    {
        Console.WriteLine("Enter the empid is::");
        empid=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the empname is::");
        empname = Console.ReadLine();
        Console.WriteLine("Enter the age is::");
        age=Int32.Parse(Console.ReadLine());
    }
    void display()
    {
        Console.WriteLine("Your value is::" + empid + "" + empname + ""+age);
    }
    public static void Main(String[] args)
    {
        Employee employee = new Employee();
        employee.get1();
        employee.display();
    }
}