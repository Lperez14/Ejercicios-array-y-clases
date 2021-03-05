using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Tabla
    {

        public void cargar(int numero)
        {
            for (int o = 1; o < 12; o++)
            {
                Console.WriteLine(o + " X " + numero + " = " + numero * o); ;
            }
        }
    }
}
