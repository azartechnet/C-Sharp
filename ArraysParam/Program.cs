class Sample
{
    public void show(params object[] val)
    {
        for(int i=0;i<val.Length; i++)
        {
            Console.WriteLine(val[i]);
        }
    }
    static void Main(string[] args)
    {
        Sample sample = new Sample();
        sample.show(1,2,3,4,5,'a',"Azar");
    }
}