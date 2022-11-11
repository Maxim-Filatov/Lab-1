using Ex_1_2;

// Двунаправленная ассоциация кратности «один к одному»
internal class Program
{
    public static void Main(String[] args)
    {
        A objectA = new A("class A");
        B objectB = new B("class B");

        objectA.ObjectB = objectB;
        objectB.ObjectA = objectA;

        // Обращение из объекта класса A, к свойству PropertyB объекта класса B.
        Console.WriteLine(objectA.ObjectB.PropertyB);
        // Обращение из объекта класса B, к свойству PropertyA объекта класса A.
        Console.WriteLine(objectB.ObjectA.PropertyA);
    }
}