using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Datos
{
    /// <summary>
    /// contiene toda la estructura de nuestra lista
    /// SAV - 16012024
    /// </summary>
    internal class ClienteDto
    {
        //CREAMOS LAS VARIBLES QUE COMPONEN NUESTRA LISTA 

        long idClienet = 0;
        string nombreCliente = "aaaaa";
        string apellidoCliente = "aaaaa";
        string nombreCompletoCliente;
        int edadClien = 0;



        //METODOS GET Y SET CON LOS QUE LEEMOS O ESBRIBIMOS EL LA LISTA

        public long IdClienet { get => idClienet; set => idClienet = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int EdadClien { get => edadClien; set => edadClien = value; }


        /// <summary>
        /// creamos un constructor que tontiene todos los parametros
        /// SAV - 16012024
        /// </summary>
        /// <param name="idClienet"></param>
        /// <param name="nombreCliente"></param>
        /// <param name="apellidoCliente"></param>
        /// <param name="nombreCompletoCliente"></param>
        /// <param name="edadClien"></param>
        public ClienteDto(long idClienet, string nombreCliente, string apellidoCliente, int edadClien)
        {
            this.IdClienet = idClienet;
            this.NombreCliente = nombreCliente;
            this.ApellidoCliente = apellidoCliente;
            this.NombreCompletoCliente = nombreCliente + apellidoCliente;
            this.EdadClien = edadClien;
        }


        /// <summary>
        /// creamos un constructor sin parametros
        /// SAV - 16012024
        /// </summary>
        public ClienteDto() { 
        
        
        }


        /// <summary>
        /// creamos nuestro metodo ToString que nos devolvera una string con todos los parametros que tenemos en nuestra lista
        /// SAV - 16012024
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        { 
            string elemento = "ID: " + this.idClienet +
                              ", Nombre: " + nombreCliente +
                              ", Apellido: "+ this.nombreCliente + 
                              ", Nombre completo: "+ this.nombreCompletoCliente + 
                              ", Edad: " + this.edadClien;

            return elemento;
        
        }
    }
}
