using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class EjemploAB
    {
        public class A
        {
            private int _value = 10;

            public int GetValue()
            {
                return _value;
            }
            public class B : A 
            { 
                
            
            }
        }
       
        public class C : A 
        {
           
        }

    }
}
