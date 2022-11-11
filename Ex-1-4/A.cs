using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_4
{
    public class A
    {
        // Properties
        public String PropertyA { get; set; }
        public B ObjectB { get; }

        // Constructor
        public A(String propertyA)
        {
            PropertyA = propertyA;
            // Реализация отношения композиции между классами A и B
            ObjectB = new B("B in A");
        }
    }
}
