using System;
class Sample
{
    int empid;
    String empname;
    public void get1(int empid,String empname)
    {

        this.empid = empid;
        this.empname = empname;
        Console.WriteLine("Your empid is::"+empid+", "+empname);
    }
    public void get2()  
    {
        Console.WriteLine("Your empid is::" + empid + ", " + empname);
    }
    public static void Main(String[] args)
    {
        Sample s1 = new Sample();
        s1.get1(1001,"azar");
        s1.get2();
    }
}