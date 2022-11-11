/* Двунаправленная ассоциация кратности "один ко многим"
   Вариант 8: структурное подразделение (осн.класс) - сотрудник (зависимый класс) */
using Ex_3;

internal class Program
{
    public static void Main(String[] args)
    {
        StructuralUnit unit = new StructuralUnit(1);
        Employee employee1 = new Employee(1, "Сотрудник_1", unit);
        Employee employee2 = new Employee(2, "Сотрудник_2", unit);
        Employee employee3 = new Employee(3, "Сотрудник_3", unit);
        
        unit.Employee1 = employee1;
        unit.Employee2 = employee2;
        unit.Employee3 = employee3;

        // Вызов метода основного класса ToString()
        Console.WriteLine(unit.ToString() + "\n");

        // Обращение из объекта зависимого класса к основному с помощью обратной ссылки и вызов метода ToString()
        Console.WriteLine(employee1.Unit.ToString());
        Console.WriteLine(employee2.Unit.ToString());
        Console.WriteLine(employee3.Unit.ToString() + "\n");

        // Вывод метода зависимого класса ToString()
        Console.WriteLine(employee1.ToString());
        Console.WriteLine(employee2.ToString());
        Console.WriteLine(employee3.ToString());
    }
}