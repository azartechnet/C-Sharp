using System;

class Sample
{
    public Sample() {
        Console.WriteLine("Welcome-1");
    }
    ~Sample() {
        Console.WriteLine("destructor");
            }
    public static void Main(String[] args)
    {
        Sample s1=new Sample();
        Sample s2=new Sample();
    }
}