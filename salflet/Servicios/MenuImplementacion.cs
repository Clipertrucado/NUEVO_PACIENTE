using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Servicios
{
    /// <summary>
    /// contiene la logica de nuestro menu
    /// SAV - 16012024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuSeleccion()
        {
            int seleccion;

            Console.WriteLine("Seleccione una de las opciones:");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("          1. Dar de alta nuevo elemento");
            Console.WriteLine("          2. Ordenar elementos");
            Console.WriteLine("          0. Cerrar");
            Console.WriteLine("---------------------------------------------------------");

            seleccion = Convert.ToInt32(Console.ReadLine());

            return seleccion;

        }
    }
}
