using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_1
{
    public class A
    {   
        // Properties
        public String PropertyA { get; set; }
        public B? ObjectB { get; set; }
        
        // Constructor
        public A(String propertyA)
        {
            PropertyA = propertyA;
        }
    }
}
