class Sample
{
    public void Show(out int val)
    {
        int squ = 5;
        val = squ;
        val *= val;
    }
    static void Main(string[] args)
    {
        int val = 50;
        Sample s = new Sample();
        Console.WriteLine("Value before Passing out variables::"+val);
        s.Show(out val);
        Console.WriteLine("Value after Passing out variables::" + val);
        
    }
}