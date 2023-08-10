public class StreamWriterExample
{
    static void Main(string[] args)
    {
        FileStream f = new FileStream("D:\\abc.txt", FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(f);
        sw.WriteLine("Welcome");
        sw.Close();
        f.Close();
        Console.WriteLine("FileCreated..");
    }
}