using System;
class Sample
{
    void get1(int empid,String empname)
    {
        Console.WriteLine("This is get1"+empid+""+empname);
    }
    void get2(int cid,String cname) {

        Console.WriteLine("This is get2"+cid+""+cname);
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("This is class");
        Sample s1 = new Sample();
        s1.get1(1001,"apple");
        s1.get2(2001,"fruit");
    }
}
