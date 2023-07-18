public class Accounts
{
    public int id;
    public string name;
    public static float rateofinst;
    public Accounts(int id,String name) 
    {
         this.id = id;
        this.name = name;
    }
    static Accounts()
    {
        rateofinst = 9.5f;
    }
    public void display()
    {
        Console.WriteLine(id+ " " + name+""+rateofinst);
    }
}
class Test1
{
    public static void Main(String[] args)
    {
        Accounts a1 = new Accounts(1001, "azar");
        Accounts a2 = new Accounts(1002, "mohamed");
        a1.display();
        a2.display();
    }
}