
int age, salary,bns;
Console.WriteLine("Enter the age is::");
age=Int32.Parse(Console.ReadLine());
if(age>=60)
{
    Console.WriteLine("Enter the Salary is::");
    salary=Int32.Parse(Console.ReadLine());
    if(salary>=20000)
    {
        bns = salary + 500;
        Console.WriteLine("Your Salary is::" + bns);
    }
    else
    {
        bns = salary + 1000;
        Console.WriteLine("Your salary is::" + bns);
    }
}
else
{
    Console.WriteLine("Your age is low..");
}