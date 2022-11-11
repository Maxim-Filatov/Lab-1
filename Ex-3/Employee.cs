using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    // Dependent class
    internal class Employee
    {
        // Properties
        public int Id { get; set; }
        public String? Name { get; set; }
        public StructuralUnit Unit { get; set; }

        public Employee(int id, String name, StructuralUnit unit)
        {
            Id = id;
            Name = name;
            Unit = unit;
        }

        // Переопределённый метод ToString() для вывода описания состояния объекта в виде строки
        public override string ToString()
        {
            return "Сотрудник={Id=" + Id + ", Name=" + Name + ", Unit=" + Unit + "}";
        }
    }
}
