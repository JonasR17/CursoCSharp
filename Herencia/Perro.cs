using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Perro : Animal
    {
        public int Anios { get; set; }
        public Perro(string nombre) : base(nombre)
        {
            Anios = 8;
        }

        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra");
        }
        public void DecirEdad()
        {
            Console.WriteLine("El perro tiene "+ Anios + " años");
        }
    }
}
