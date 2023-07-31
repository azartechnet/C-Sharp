class Sample
{
    public void get1(int a)
    {
        Console.WriteLine(a);
    }
    public void get1(String name)
    {
        Console.WriteLine(name);
    }
}
class MainApp
{
    static void Main(string[] args)
    {
        Sample sample = new Sample();
        sample.get1(100);
        sample.get1("azar");        
    }
}