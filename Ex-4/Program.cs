// Отношение агрегации «один ко многим»
using Ex_4;

internal class Program
{
    public static void Main(String[] args)
    {
        StructuralUnit unit = new StructuralUnit(1);
        for (int i = 0; i < 3; i++)
        {
            unit.UnitStaff.Add(new Employee(i, "Name_" + i));
        }
        Console.WriteLine(unit.ToString());
    }
}