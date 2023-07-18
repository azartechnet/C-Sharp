
using System;
class Sample
{
    Sample() 
    {
        Console.WriteLine("default cons...");
    }
    Sample(int x,String name) 
    {
        Console.WriteLine("Your value is::" + x + "" + name);
    }
    public static void Main(String[] args)
    {
         new Sample();
        new Sample(1001, "Azar");
    }
}