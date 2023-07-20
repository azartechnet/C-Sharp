using System;
public class EnumExample
{
    public enum empname {mohamed,azar,sheik};

    public static void Main()
    {
        foreach(int s in Enum.GetValues(typeof(empname)))
        {
            Console.WriteLine(s);
        }
    }
}