using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_2
{
    public class B
    {
        // Properties
        public String PropertyB { get; set; }
        public A? ObjectA { get; set; }

        // Constructor
        public B(String propertyB)
        {
            PropertyB = propertyB;
        }
    }
}
