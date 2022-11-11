using Ex_1_3;

internal class Program
{
    public static void Main(String[] args)
    {
        A objectA = new A("class A");
        B objectB = new B("class B");

        // Реализация отношения агрегации между классами A и B
        objectA.ListB.Add(objectB);

        Console.WriteLine(objectA.ListB.ElementAt(0).PropertyB);
    }
}