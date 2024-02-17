using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    using System;
    class Program
    {
        static void Main()
        {
            // Declaración y asignación de variables
            int edad = 30;
            string nombre = "Ana";
            bool esEstudiante = false;

            // Uso de variables en operaciones y métodos
            edad = edad + 1; // Incrementa la edad en 1
            edad += 1; // Incrementa la edad en 1 (es la misma acción de la linea de arriba)

            Console.WriteLine("Nombre: " + nombre); 
            Console.WriteLine("Edad: " + edad);  
            Console.WriteLine("Edad: " + esEstudiante);
        }
    }

}
