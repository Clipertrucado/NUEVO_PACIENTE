using salflet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Servicios
{
    /// <summary>
    /// contiene las cabeceras de los metodos a los que llamaremos desde el metodo Main
    /// SAV - 16012024
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// sera el encargado de añadir un nuevo cliente a la lista 
        /// /// SAV - 16012024
        /// </summary>
        /// <param name="listaCompleta"></param>
        public void añadirCliente(List<ClienteDto> listaCompleta);

        /// <summary>
        /// este metodo valida que como minimo tengamos 3 clientes dentro de la lista
        /// SAV - 16012024
        /// </summary>
        /// <param name="listaCompleta"></param>
        public void validarClientes(List<ClienteDto> listaCompleta);

    }
}
