// Глубокое клонирование объекта
using Ex_6;

internal class Program
{
    public static void Main(String[] args)
    {
        StructuralUnit unit = new StructuralUnit(1);
        for (int i = 0; i < 3; i++)
        {
            unit.UnitStaff.Add(new Employee(i, "Name_" + i));
        }
        Console.WriteLine(unit.ToString() + "\n");

        // Клонирование объекта
        StructuralUnit unitClone = unit.Clone();
        // Вызов метода ToString() на корне агрегата
        Console.WriteLine(unitClone.ToString());
    }
}