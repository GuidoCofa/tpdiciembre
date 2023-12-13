public class Equipo{
    public int idEquipo {get; set;}
    public string Nombre {get; set;}
    public string Imagen {get; set;}

    public Equipo(){}

    public Equipo(string nombre, string imagen){
        Nombre = nombre;
        Imagen = imagen;
    }
}