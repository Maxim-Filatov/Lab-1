/* Однонаправленная ассоциация кратности "один ко многим"
   Вариант 8: структурное подразделение (осн.класс) - сотрудник (зависимый класс) */
using Ex_2;

internal class Program
{
    public static void Main(String[] args)
    {
        Employee employee1 = new Employee(1, "Сотрудник_1");
        Employee employee2 = new Employee(2, "Сотрудник_2");
        Employee employee3 = new Employee(3, "Сотрудник_3");
        Employee employee4 = new Employee(4, "Сотрудник_4");
        Employee employee5 = new Employee(5, "Сотрудник_5");

        StructuralUnit unit = new StructuralUnit(1, employee1, employee2, employee3, employee4, employee5);

        Console.WriteLine(unit.ToString());
    }
}