class Sample
{
    public string Show(string msg)
    {
        Console.WriteLine("Inside Show Function");
        return msg;
    }

    static void Main(string[] args)
    {
        Sample sample = new Sample();
        string msg=sample.Show("Welcome");
        Console.WriteLine("Hello" + msg);
    }
}