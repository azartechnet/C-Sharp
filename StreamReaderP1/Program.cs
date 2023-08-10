public class StreamReaderExample
{
    static void Main(string[] args)
    {
        FileStream f = new FileStream("D:\\abc.txt", FileMode.OpenOrCreate);


        StreamReader sr = new StreamReader(f);

        string line = sr.ReadLine();

        Console.WriteLine(line);
    }
}