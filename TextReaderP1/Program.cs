class Sample
{
    static void Main(String[] args)
    {
        using (TextReader writer = File.OpenText("D:\\f1.txt"))
        {
            Console.WriteLine(writer.ReadLine());

        }
       
    }
}