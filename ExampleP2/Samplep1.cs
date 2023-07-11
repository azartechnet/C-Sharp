public class Program1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the a value is::");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Its Even.." + a);
        }
        else
        {
            Console.WriteLine("Its Odd.." + a);
        }
    }
}