using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    // Main class
    internal class StructuralUnit
    {
        // Properties
        public int UnitNumber { get; set; }
        // Ссылка на коллекцию объектов зависимого класса
        public Employee? Employee1 { get; set; }
        public Employee? Employee2 { get; set; }
        public Employee? Employee3 { get; set; }

        // Constructor
        public StructuralUnit(int unitNumber)
        {
            UnitNumber = unitNumber;
        }

        // Переопределённый метод ToString() для вывода описания состояния объекта в виде строки
        public override string ToString()
        {
            return "Структурное подразделение={" + "UnitNumber=" + UnitNumber + "}";
        }
    }
}
