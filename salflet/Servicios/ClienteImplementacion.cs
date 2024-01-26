using salflet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace salflet.Servicios
{
    /// <summary>
    /// Clase encargada de la logica de la aplicacion 
    /// SAV - 16012024
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {

        public void añadirCliente(List<ClienteDto> listaCompleta)
        {
            //igualamos nuestro elemento con un metodo que creara y devolvera un tipo elementoDto y de esta forma abstraer el codigo
            ClienteDto elemento = crearCliente();

            //añadimos a nuestra lista el elemento creado 
            listaCompleta.Add(elemento);

            mostraLista(listaCompleta);
        }

        /// <summary>
        /// este metodo creara y devuelve un elemento que contenga los datos que el cliente introduzca 
        /// SAV - 16012024
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearCliente() { 

            ClienteDto nuevoElemento = new ClienteDto();

            Console.WriteLine("Completa:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Id del cliente: ");
            long id = Convert.ToInt64(Console.ReadLine());
            

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Nombre del Cliente: ");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Apellido del Cliente: ");
            string apellido = Console.ReadLine();


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Edad del elemento: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            nuevoElemento = new ClienteDto(id, nombre, apellido, edad);

            return nuevoElemento;
        }

        /// <summary>
        /// este metodo muestra los cliente introducidos 
        /// SAV - 16012024
        /// </summary>
        /// <param name="listaCompleta"></param>
        public void mostraLista(List<ClienteDto> listaCompleta)
        {
            //mostramso mediante un foreach todas las posiciones de la lista
            foreach (ClienteDto elemento in listaCompleta) { 
                Console.WriteLine(elemento.ToString()); 
            }
   
        }

        /// <summary>
        /// este metodo ordena los cliente introducidos 
        /// SAV - 16012024
        /// </summary>
        /// <param name="lisCompleta"></param>
        private void ordenarClientes(List<ClienteDto> lisCompleta) {


            for (int i = 0; i < lisCompleta.Count - 1; i++)
            {
                for (int j = 0; j < lisCompleta.Count - 1 - i; j++)
                {
                    if (lisCompleta[j].EdadClien < lisCompleta[j + 1].EdadClien)
                    {
                        ClienteDto aux = lisCompleta[j];
                        lisCompleta[j] = lisCompleta[j + 1];
                        lisCompleta[j + 1] = aux;
                    }
                }
            }

           
        }

        /// <summary>
        /// este metodo ordena los cliente introducidos 
        /// SAV - 16012024
        /// </summary>
        /// <param name="lisCompleta"></param>
        private void ordenarFacil(List<ClienteDto> listaCompleta) {

            listaCompleta.OrderByDescending(ob => ob.EdadClien).ToArray();
           
        }

        
        public void validarClientes(List<ClienteDto> listaCompleta)
        {


            if (listaCompleta.Count >= 3)
            {
                mostrarPoco(listaCompleta);

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("LISTA ORDENADA");

                ordenarClientes(listaCompleta);
                mostrarPoco(listaCompleta);
            }
            else {

                Console.WriteLine("Se necesitan como minimo que se añadan 3 clientes antes de poder ordenar");
            
            }
        }

        /// <summary>
        /// Este metodo es el encargado de mostrar solo el nombre completo y edad de los clientes de la lista
        /// SAV - 160124
        /// </summary>
        /// <param name="listaCompleta"></param>
        private void mostrarPoco(List<ClienteDto> listaCompleta) { 

            foreach (ClienteDto elemento in listaCompleta)
            {
                Console.WriteLine("Nombre completo: " + elemento.NombreCompletoCliente + "Edad: " + elemento.EdadClien);
            }

        }
    }
}
