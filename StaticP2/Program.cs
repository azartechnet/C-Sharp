static class  Sample
{
    public static float PI = 3.14f;
    public static int cube(int n)
    {
        return n * n * n;
    }
    
}
class Demo
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Value of PI::" + Sample.PI);
        Console.WriteLine("Value of Cube::" + Sample.cube(2));
    }
}