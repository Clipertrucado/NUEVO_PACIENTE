package edu.Salflet.Servicios;
import java.util.ArrayList;
import java.util.List;

import Dtos.ClientesDtos;
import Dtos.EsclavosDtos;

/**
 * contiene las cabeceras de los metodos a los que puede accederse desde el metodo main 
 * SAV - 05122023
 */
public interface OperativaInterfaz {                      

	public void anadirCliente(List<ClientesDtos> listaCompleta, List<EsclavosDtos> listaCompleta2);
	
	
	
	
}
