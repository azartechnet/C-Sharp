public class FileExample2
{
    static void Main(String[] args)
    {
        FileStream f=new FileStream("D:\\abc.txt",FileMode.OpenOrCreate);
        for(int i=65;i<=90;i++)
        {
            f.WriteByte((byte)i);
        }
        f.Close();
    }
}