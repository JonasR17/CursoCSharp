using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Persona
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        //ESTO ES EL CONSTRUCTOR 
        public Persona()
        {
            Name = " Naels";
            Birthday = new DateTime(2000,07,08);
        }
        public Persona(string name)
        {
            Name = name;
          //  Birthday = birthday;
        }   
    }
}
