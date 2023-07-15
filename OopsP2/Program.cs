class Sample
{
    int empid;
    String empname;
    public void input()
    {
        Console.WriteLine("Enter the empid and empname is::");
        empid = Int32.Parse(Console.ReadLine());
        empname = Console.ReadLine();
        Console.WriteLine("Your data is::" + empid + "" + empname);

    }
    public static void Main(String[] args)
    {
        Sample sample = new Sample();
        sample.input();
    }
}
