package Dtos;


public class ClientesDtos {

	
	
	int id;
	String especie = "aaaaa";
	int edad= 99999;
	int idEsclavo;
	
	
	

	public int getIdEsclavo() {
		return idEsclavo;
	}

	public void setIdEsclavo(int idEsclavo) {
		this.idEsclavo = idEsclavo;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getEspecie() {
		return especie;
	}

	public void setEspecie(String especie) {
		this.especie = especie;
	}

	public int getEdad() {
		return edad;
	}

	public void setEdad(int edad) {
		this.edad = edad;
	}
	
	public ClientesDtos(int id, String especie, int edad, int idEsclavo) {
		super();
		this.id = id;
		this.especie = especie;
		this.edad = edad;
		this.idEsclavo = idEsclavo;
	}

	public ClientesDtos() {
		super();
	}

	@Override
	public String toString() {
		return "ClientesDtos [id=" + id + ", especie=" + especie + ", edad=" + edad + ", idEsclavo=" + idEsclavo + "]";
	}
	
	
	
}
