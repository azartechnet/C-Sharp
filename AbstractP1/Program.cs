public abstract class Sample
{
    public abstract void get1();
    public void get2()
    {
        Console.WriteLine("Normal Methods..");
    }

}
public class Foo:Sample
{

    override
    public void get1()
    {
        Console.WriteLine("This is Abstract Class");
    }
}
class MainApp
{
    static void Main(string[] args)
    {
        Foo f1=new Foo();
        f1.get1();
        f1.get2();
    }
}