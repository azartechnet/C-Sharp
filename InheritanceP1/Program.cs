class B
{
     public int pid;
    public void get1()
    {
       pid=Int32.Parse(Console.ReadLine());
    }
}
class D1 : B
{
    public String pname = "apple";
}
class D2:D1
{
    public void get2()
    {
        Console.WriteLine("Base class value is::" + pid+""+pname);
    }
}
class MainDemo
{
    static void Main(string[] args)
    {
        D2 s1=new D2();
        s1.get1();
        s1.get2();
    }
}
