/*class LinkedListE1
{
    public static void Main(String[] args)
    {
        var no=new LinkedList<int>();
        no.AddLast(12);
        no.AddLast(13);
        no.AddLast(14);
        no.AddLast(15);
        no.AddFirst(16);

        LinkedListNode<int>node=no.Find(16);
        no.AddBefore(node,100);
        no.AddAfter(node,200);
       


        foreach(var name in no) 
        {
            Console.WriteLine(name);    

        }

    }
}*//*
class name
{
    static void val(string name,int v)

    {
        Console.WriteLine(name + ":" + v);
    }
    static void Main(string[]args)
    {
       SortedList<string,int> dic = new SortedList<string,int>();
        dic.Add("r"  ,   1);
        dic.Add("g"  , 6);
        dic.Add("b"  , 3);
        dic.Add("c"  , 9);
        //name n1= new name();
        val("ragavan", 100);
        //Console.WriteLine(dic.);
       foreach(KeyValuePair<string,int>  i in dic)
        {
            Console.WriteLine(i.Key+""+i.Value);
           // Console.WriteLine(dic.Remove("c"));
        }
    }
}*/
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class name
{
    public void nam(String name,int no)
    {
        Console.WriteLine(name + " " + no);
    }
    static void Main(String[] args)
    {
        FileStream val = new FileStream("D:\\monnn.txt", FileMode.Create);
        BinaryFormatter ba = new BinaryFormatter();
        name n1= new name();
        n1.nam("ragavn", 100);
        ba.Serialize(val,n1);
        val.Close();
    }
}