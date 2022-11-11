// Отношение композиции «один ко многим»
using Ex_5;

internal class Program
{
    public static void Main(String[] args)
    {
        StructuralUnit unit = new StructuralUnit(1, 1, "Сотрудник_1", 2, "Сотрудник_2", 3, "Сотрудник_3");

        Console.WriteLine(unit.ToString());
    }
}