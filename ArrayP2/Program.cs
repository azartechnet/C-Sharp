class Sample
{
    int[,] empid = new int[2,2];
    int i, j, n, m;
    void fun1()
    {
        Console.WriteLine("Enter the n and m value is::");
        n=Int16.Parse(Console.ReadLine());
        m= Int16.Parse(Console.ReadLine());
        for(i=0;i<=n;i++)
        {
            for(j=0;j<=m;j++)
            {
                Console.WriteLine("Enter the value is::");
                empid[i,j] = Int32.Parse(Console.ReadLine());

            }
        }
    }
    void fun2() {
        for (i = 0; i <= n; i++)
        {
            for (j = 0; j <= m; j++)
            {
                Console.WriteLine("Your value is::" + empid[i,j]);
                

            }
        }
    }
    static void Main(String[] args)
    {
        Sample sample = new Sample();
        sample.fun1();
        sample.fun2();
    }
}