package edu.Salflet.Servicios;

import java.util.Scanner;

/**
 * contiene las cabeceras de los metodos a los que puede accederse desde el metodo main 
 * SAV - 05122023
 */
public interface MenuInterfaz {

	/**
	 * metodo encargado de mostrar nuestro menu un recoger la funcionalidad que el usuario desea
	 * SAV - 05122023
	 * @param sc
	 * @return
	 */
	public int menuSeleccion(Scanner sc);
}
