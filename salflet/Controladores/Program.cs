using salflet.Datos;
using salflet.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Controladores
{
    /// <summary>
    /// clase principal de nuestra aplicación
    /// SAV - 16012024
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// contendra el flujo principal de la aplicación
        /// SAV - 16012024
        /// </summary>
        public static void Main() { 
            
            //creamos variables de tipo interfaz para poder llamar a los metodos que contienen
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();

            //creamos list tipo lista que tiene la referencia de memoria donse se guardan los clienetes de toda nuestra lista
            List<ClienteDto> list = new List<ClienteDto>();

            bool cerrar = false;

            //while con el que haremos que el cliente se mantenga en bucle hata que seleccione lo contrario
            while (!cerrar)
            {
                //mostramos el menu y le damos a op el valor seleccionado
                int op = mi.menuSeleccion(); 

                //usamos op con un Switch para controlar que opcion se a seleccionado
                switch (op)
                {
                    case 0:
                        //cerramos el bucle
                        cerrar = true;
                        break;
                    case 1:
                        //llamamos a metodo y le pasamos la lista
                        ci.añadirCliente(list);
                        break;
                    case 2:
                        //llamamos a metodo y le pasamos la lista
                        ci.validarClientes(list);
                        break;
                   
                      
                    
                }

            }
        
        }
    }
}
