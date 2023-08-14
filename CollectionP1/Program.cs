class Sample
{
    public static void Main(String[] args)
    {
        //Creating a list of String
        /*var names=new List<string>();
        names.Add("a");
        names.Add("b"); 
        names.Add("c");

        foreach(var name in names) 
        {
            Console.WriteLine(name);
        }*/

        var n1=new List<int>();
        n1.Add(1001);
        n1.Add(1002);
        n1.Add(1003);
        n1.Add(1003);
        foreach(var n2 in n1)
        {
            Console.WriteLine(n2.ToString());
        }
    }
}