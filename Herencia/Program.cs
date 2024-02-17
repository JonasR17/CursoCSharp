using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var perro = new Perro("firulais");
            Console.WriteLine($"El perro se llama {perro.Nombre}");
            perro.HacerSonido();
            perro.DecirEdad();
        }
    }
}
