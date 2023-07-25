class Sample
{
    int[] empid = new int[2];
    int i, n;
    void get()
    {
        Console.WriteLine("Enter the n value is::");
        n=Int32.Parse(Console.ReadLine());
        for(i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the empid is::");
            empid[i]=Int32.Parse(Console.ReadLine());

        }
    }
    void get2()
    {
        for(i = 0;i < n;i++)
        {
            Console.WriteLine("Your value is::" + empid[i]);
        }
    }
    static void Main(String[] args)
    {
        Sample s = new Sample();
        s.get();
        s.get2();
    }
}