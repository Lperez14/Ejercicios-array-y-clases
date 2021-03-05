using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class valores
    {
        public string nombre{ get; set; }
        public int edad { get; set; }

        public valores(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public void cargar()
        {

            Console.WriteLine("Nombre de la persona:" + nombre);
            Console.WriteLine("Edad de la persona: " + edad);

            if(edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad");
            }
        }

    }
}
