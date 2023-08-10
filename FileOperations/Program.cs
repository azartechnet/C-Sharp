public class FileStreamP1
{
    static void Main(String[] args)
    {
        FileStream f=new FileStream("D:\\abc1.txt",FileMode.OpenOrCreate);
        f.WriteByte(65);
        f.Close();
    }
}