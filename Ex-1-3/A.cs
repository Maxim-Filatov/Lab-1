using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_3
{
    internal class A
    {

        // Properties
        public String PropertyA { get; set; }
        public List<B> ListB { get; set; }

        // Constructor
        public A(String propertyA)
        {
            PropertyA = propertyA;
            ListB = new List<B>();
        }
    }
}
