using System;
class Sample
{
    int empid;
    string empname;
    void input()
    {
        Console.WriteLine("Enter the empid and empname is::");
        empid=Int32.parse(Console.ReadLine());
        empname=Int32.parse(Console.ReadLine());
        Console.WriteLine("Your data is::" + empid + "" + empname);

    }
    public static void main(string[] args)
    {
        Sample sample = new Sample();
        sample.input();
    }
}
