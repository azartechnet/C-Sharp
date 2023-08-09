class Sample
{
    void get1()
    {
        try
        {
            int a = 100;
            int c;
            c = a / 0;
            Console.WriteLine(c);
        }
        catch (ArithmeticException e) 
        {
            Console.WriteLine(e.ToString());
        }

        get2();
    }
    void get2()
    {
        try
        {
            string s =null;
            Console.WriteLine(s.Length);
        }
        catch(NullReferenceException e)
        {
            Console.Write(e.ToString());
        }
        finally
        {
            Console.WriteLine("finally block");
        }
        get3();
    }
    void get3()
    {
        Console.WriteLine("This is normal function...");
    }
    static void Main(string[] args)
    {
        Sample s1= new Sample();    
        s1.get1();
    }
}