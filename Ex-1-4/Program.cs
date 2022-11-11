using Ex_1_4;

internal class Program
{
    public static void Main(String[] args)
    {
        A objectA = new A("class A");

        Console.WriteLine(objectA.ObjectB.PropertyB);
    }
}