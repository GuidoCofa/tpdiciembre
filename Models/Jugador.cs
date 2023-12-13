public class Jugador{
    public int idJugador {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int NumeroCamiseta {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public string Imagen {get; set;}
    public int idEquipo {get; set;}

    public Jugador(){}

    public Jugador(string nombre, string apellido, int numerocamiseta, DateTime fechanacimiento, string imagen, int idequipo){
        Nombre = nombre;
        Apellido = apellido;
        NumeroCamiseta = numerocamiseta;
        FechaNacimiento = fechanacimiento;
        Imagen = imagen;
        idEquipo = idequipo;
    }
}