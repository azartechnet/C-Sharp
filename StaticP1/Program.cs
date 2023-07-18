class Sample
{
    public int accno;
    public String name;
    public static float rateofinst = 8.8f;
    public Sample(int accno,String name) 
    {
        this.accno = accno;
        this.name = name;
            
    }
    public void display()
    {
        Console.WriteLine(accno + " " + name+""+ rateofinst);
    }
    public static void Main(String[] args)
    {
        Sample sample = new Sample(1001,"azar1");
        Sample sample1 = new Sample(1002,"azar2");
        sample.display();
        sample1.display();
    }
}