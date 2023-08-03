class PublicTest
{
    public string name = "mohamed";
    public void Msg(string msg)
    {
        Console.WriteLine(msg);
    }
}
class Program
{
    static void Main(string[] args)
    {
        PublicTest f1=new PublicTest();
        Console.WriteLine("Hello"+f1.name);

        f1.Msg("Hello");
    }
}