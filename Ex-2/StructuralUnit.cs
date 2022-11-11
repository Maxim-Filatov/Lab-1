using Ex_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
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
        public Employee Employee4 { get; set; }
        public Employee Employee5 { get; set; }

        // Constructor
        public StructuralUnit(int unitNumber, Employee e1, Employee e2, Employee e3, Employee e4, Employee e5)
        {
            UnitNumber = unitNumber;
            Employee1 = e1;
            Employee2 = e2;
            Employee3 = e3;
            Employee4 = e4;
            Employee5 = e5;
        }

        // Переопределённый метод ToString() для вывода описания состояния объекта в виде строки
        public override string ToString()
        {
            return "Структурное подразделение={\n" + "UnitNumber=" + UnitNumber +
                ",\nСотрудник_1=" + Employee1 + ",\nСотрудник_2=" + Employee2 +
                ",\nСотрудник_3=" + Employee3 + ",\nСотрудник_4=" + Employee4 +
                ",\nСотрудник_5=" + Employee5 + "\n}";
        }
    }
}
