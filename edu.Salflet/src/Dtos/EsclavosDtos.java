package Dtos;

public class EsclavosDtos {

	int id;
	String nombre;
	String dni;
	int fecha;
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public String getDni() {
		return dni;
	}
	public void setDni(String dni) {
		this.dni = dni;
	}
	public int getFecha() {
		return fecha;
	}
	public void setFecha(int fecha) {
		this.fecha = fecha;
	}
	
	public EsclavosDtos(int id, String nombre, String dni, int fecha) {
		super();
		this.id = id;
		this.nombre = nombre;
		this.dni = dni;
		this.fecha = fecha;
	}
	
	public EsclavosDtos() {
		super();
	}
	
	@Override
	public String toString() {
		return "EsclavosDtos [id=" + id + ", nombre=" + nombre + ", dni=" + dni + ", fecha=" + fecha + "]";
	}
	
	
}
