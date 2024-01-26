package edu.Salflet.Servicios;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import Dtos.ClientesDtos;
import Dtos.EsclavosDtos;
/**
 * contiene la logiga de cada funcionalidad de nuestra aplicacion y como minimo las cabeceras creadas en la interfaz
 * SAV - 05122023
 */
public class OperativaImplementacion implements OperativaInterfaz {

	Scanner sc = new Scanner(System.in);

	@Override
	public void anadirCliente(List<ClientesDtos> listaCompleta, List<EsclavosDtos> listaCompleta2) {
		// TODO Auto-generated method stub
		
		ClientesDtos nuevoElemento = new ClientesDtos();
		nuevoElemento = nuevoCliente();
		
		listaCompleta.add(nuevoElemento);
		boolean i = true;
		
		for (EsclavosDtos lista : listaCompleta2){
			if (nuevoElemento.getIdEsclavo()==lista.getId()) {
				System.out.print("Cliente encontrado");
				lista.toString();
				
				i = false;
			}
		}
		
		if (i) {
			System.out.println("-------------------------------");
			System.out.println("clienete no encontrado");
			anadirEsclavo(listaCompleta2);
		}
	}

	private ClientesDtos nuevoCliente() {
		
		ClientesDtos nuevoElemento = new ClientesDtos();
		System.out.println("-------------------------------");
		System.out.print("Escribe el id:");
		nuevoElemento.setId(sc.nextInt());
		
		System.out.print("Escribe la especie:");
		nuevoElemento.setEspecie(sc.next());
		
		System.out.print("Escribe el edad:");
		nuevoElemento.setEdad(sc.nextInt());
		
		System.out.print("Escribe el id del esclavo:");
		nuevoElemento.setIdEsclavo(sc.nextInt());
		System.out.println("-------------------------------");
		
		return(nuevoElemento);
	}

	private void anadirEsclavo(List<EsclavosDtos> listaCompleta) {
		// TODO Auto-generated method stub
		listaCompleta.add(nuevoEsclavo());
	}
	
	private EsclavosDtos nuevoEsclavo() {
		
		EsclavosDtos nuevoElemento = new EsclavosDtos();
		System.out.println("-------------------------------");
		System.out.print("Escribe el id:");
		nuevoElemento.setId(sc.nextInt());
		
		System.out.print("Escribe el nombre:");
		nuevoElemento.setNombre(sc.next());
		
		System.out.print("Escribe el DNi");
		nuevoElemento.setDni(sc.next());
		System.out.println("-------------------------------");
		
		
		return(nuevoElemento);
	}
	

	
}
