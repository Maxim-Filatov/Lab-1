using Ex_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    // Main class
    internal class StructuralUnit
    {
        // Properties
        public int UnitNumber { get; set; }
        // Ссылка на коллекцию объектов зависимого класса
        public List<Employee> UnitStaff { get; set; }

        // Constructor
        public StructuralUnit(int unitNumber)
        {
            UnitNumber = unitNumber;
            UnitStaff = new List<Employee>();
        }

        // Переопределённый метод ToString() для вывода описания состояния объекта в виде строки
        public override string ToString()
        {
            return "Структурное подразделение={\n" + "UnitNumber=" + UnitNumber + ",\nСотрудники=[" + String.Join(", ", UnitStaff) + "]\n}";
        }
    }
}
