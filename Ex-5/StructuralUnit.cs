using Ex_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    // Main class
    internal class StructuralUnit
    {
        // Properties
        public int UnitNumber { get; set; }
        // Пять экземпляров зависимого класса
        public Employee Employee1 { get; set; }
        public Employee Employee2 { get; set; }
        public Employee Employee3 { get; set; }

        // Constructor
        public StructuralUnit(int unitNumber, int id1, String name1, int id2, String name2, int id3, String name3)
        {
            UnitNumber = unitNumber;
            Employee1 = new Employee(id1, name1);
            Employee2 = new Employee(id2, name2);
            Employee3 = new Employee(id3, name3);
        }

        // Переопределённый метод ToString() для вывода описания состояния объекта в виде строки
        public override string ToString()
        {
            return "Структурное подразделение={\n" + "UnitNumber=" + UnitNumber +
                ",\nСотрудник_1=" + Employee1 + ",\nСотрудник_2=" + Employee2 +
                ",\nСотрудник_3=" + Employee3 + "\n}";
        }
    }
}
