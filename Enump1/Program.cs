using System;
public class EnumExample
{
    public enum enames {azar,mohamed,sheik}

    public static void Main()
    {
        int x=(int)enames.azar;
        int y=(int)enames.mohamed;
        Console.WriteLine("Your name is::" + x);
        Console.WriteLine("Your name is::" + y);
    }
}