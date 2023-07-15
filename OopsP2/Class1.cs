using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsP2;

public class Sample1
{
    public int id;
    public String name1;

    public static void Main(String[] args)
    {
        Sample1 d1=new Sample1();
        d1.id=1001;
        d1.name1 = "azar";
        Console.WriteLine(d1.id);
        Console.WriteLine(d1.name1);
    }
}
