using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFicheros.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Adeudosepa");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
