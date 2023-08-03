class PublicTest
{
    protected string name = "mohamed";
    protected void Msg(string msg)
    {
        Console.WriteLine(msg);
    }
}
class Program:PublicTest
{
    static void Main(string[] args)
    {
        Program f1 = new Program();
        Console.WriteLine("Hello" + f1.name);

        f1.Msg("Hello");
    }
}