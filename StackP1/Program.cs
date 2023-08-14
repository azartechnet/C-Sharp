class Sample
{
    static void Main(string[] args)
    {
        Stack<string> s1 = new Stack<string>();

        s1.Push("a");
        s1.Push("b");   
        s1.Push("c");
        s1.Push("d");
       // s1.Push("d");

        foreach (string s in s1)

        {
            Console.WriteLine("Looping..."+s);
        }
        Console.WriteLine("Pop elements::"+s1.Pop());
        Console.WriteLine("Peek elements:::"+s1.Peek());   

    }
}