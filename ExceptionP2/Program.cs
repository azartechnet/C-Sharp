public class AzarException:Exception
{
    public AzarException(String msg):base(msg)
    {

    }
}
public class TestApplication
{

    static void validate(int age)
    {
        if (age < 18)
        {
            throw new AzarException("Sorry");
        }
        else
        {
            Console.WriteLine("Welcome");
        }
    }

    public static void Main(String[] args)
    {
        try
        {
            validate(20);
        }
        catch (AzarException e) 
        {
            Console.WriteLine(e.Message);
        }
}
}
