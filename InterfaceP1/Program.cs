public interface B
{
    public void get1();
}
public interface B2:B
{
    public void get2();
}
class D:B2
{
    public void get1()
    {
        Console.WriteLine("InterfaceConcepts..");
    }
    public void get2()
    {
        Console.WriteLine("Interface-2");
    }
}
class MainDemo
{
    static void Main(string[] args)
    {
        D f1 = new D();
        f1.get1();
        f1.get2();
    }
}