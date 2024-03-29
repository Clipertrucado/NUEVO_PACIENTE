﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Servicios
{
    /// <summary>
    /// contiene las cabeceras de los metodos a los que se puede llamar desde el metod Main
    /// SAV - 16012024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// muestra las diferentes funciones de nuestra aplicacion, pide un tipo int y lo devuelve
        /// SAV - 16012024
        /// </summary>
        /// <returns></returns>
        public int menuSeleccion();
    }
}
