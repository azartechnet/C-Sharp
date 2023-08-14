class Sample
{
    static void Main(string[] args)
    {
       /* var n1=new HashSet<int>(); */ 
       var n1=new SortedSet<int>();
        n1.Add(1002);
        n1.Add(1001);
        n1.Add(1003);
        n1.Add(1003);
        foreach(var i in n1)
        {
            Console.WriteLine(i);
        }
    }
}