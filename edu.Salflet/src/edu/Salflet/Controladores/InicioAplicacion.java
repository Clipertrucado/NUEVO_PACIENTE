package edu.Salflet.Controladores;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import Dtos.ClientesDtos;
import Dtos.EsclavosDtos;
import edu.Salflet.Servicios.MenuImplementacion;
import edu.Salflet.Servicios.MenuInterfaz;
import edu.Salflet.Servicios.OperativaImplementacion;
import edu.Salflet.Servicios.OperativaInterfaz;

/**
 * Es la clase principal de nuestra aplicacion
 * SAV - 051122023
 */
public class InicioAplicacion {
	
	/**
	 * Nuestro metodo main se contiene el fliujo de nuestra aplicacion 
	 * SAV - 051122023
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//creamos nuestro escanes y las copias de las interfaces
		Scanner sc = new Scanner(System.in);
		MenuInterfaz mi = new MenuImplementacion();
		OperativaInterfaz oi = new OperativaImplementacion();
		
		List<ClientesDtos> listaClientes = new ArrayList<ClientesDtos>();
		
		List<EsclavosDtos> listaEsclavos = new ArrayList<EsclavosDtos>();
		
		
		
		
		boolean cerrar = false;
		
		//hacemos que se mantenga en bucle 
		while(!cerrar) {
			
			int seleccion = mi.menuSeleccion(sc);
			
			switch (seleccion) {
			
				case 0:
					cerrar=true;
					
					break;
					
				case 1:
					oi.anadirCliente(listaClientes, listaEsclavos);
					break;
				
				
				}
			
				
			}
			
			
		}
	
	
	}


