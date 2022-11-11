using Ex_1_1;

// Однонаправленная ассоциация от класса A к классу B кратности «один к одному».
internal class Program
{
    public static void Main(String[] args)
    {
        A objectA = new A("class A");
        B objectB = new B("class B");

        // Ассоциация от класса A к классу B
        objectA.ObjectB = objectB;

        Console.WriteLine(objectA.ObjectB.PropertyB);
    }
}