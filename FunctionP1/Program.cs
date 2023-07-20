class Sample
{
    int pid;
    String pname;
    public void get1()
    {
        Console.WriteLine("Enter the PID value is::");
        pid=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Your Pid is::" + pid);
    }
    public void get2()
    {
        Console.WriteLine("Enter the PNAME is::");
        pname = Console.ReadLine();
        Console.WriteLine("Your Pname is::" + pname);
    }
}
class Demo
{
    public static void Main(String[] args)
    {
        Sample s1=new Sample();
        s1.get1();
        s1.get2();
    }
}