class Sample
{
    static void Main(String[] args)
    {
        using (TextWriter writer = File.CreateText("D:\\f1.txt")) 
        {
            writer.WriteLine("Hello");
            writer.WriteLine("C#FileHandling by Java");

        }
        Console.WriteLine("DataWrittern Sucessfully");
    }
}