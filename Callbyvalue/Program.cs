using System;
class Sample
{
    public void get(int val)
    {
        val *= val;
        Console.WriteLine("value inside the get function.."+val);
    }
    static void Main(String[] args)
    {
        int val = 50;
        Sample s1 = new Sample();
        Console.WriteLine("Value before calling the function::" + val);
        s1.get(val);
        Console.WriteLine("Value after calling the function::" + val);
    }
}